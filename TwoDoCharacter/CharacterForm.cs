using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using TwoDoCustomForm;
using TwoDoInterfaces;
using TwoDoUtils;

namespace TwoDoCharacter
{
    public partial class CharacterForm : CustomForm, ITwoDoMdiForm, ITwoDoXml
    {
        public event EventHandler MdiExitClick;
        public CustomGridPanel CharacterGrid;
        private NewCharacterForm newCharForm;        
       
        public CharacterForm(bool onlyCloseButton) : base(onlyCloseButton, false)
        {            
            InitializeComponent();
            MainMenuBar.BarColor = Color.FromArgb(70,70,70);
            MainMenuBar.BarGradientColorStart = Color.FromArgb(70, 70, 70);
            MainMenuBar.BarGradientColorEnd = Color.FromArgb(70, 70, 70);           

            menuTitle = "Character";
            CharacterGrid = new CustomGridPanel(this.ClientRectangle);
            CharacterGrid.Padding = new Padding(1,1,0, 30);
            CharacterGrid.FloatingMenu.MenuItems.Add(new MenuItem("New Character", newCharacter_click));
            CharacterGrid.FloatingMenu.MenuItems.Add(new MenuItem("Sort", Sort_click));
            this.Controls.Add(CharacterGrid);            
        }

        private void Sort_click(object sender, EventArgs e)
        {
            
        }

        private void newCharacter_click(object sender, EventArgs e)
        {
            newCharForm = new NewCharacterForm();   
            newCharForm.Save += newCharForm_Save;
            newCharForm.ShowDialog();
        }

        private void newCharForm_Save(object sender, EventArgs e)
        {
            var character = (sender as NewCharacterForm).character;
            if ((e as NewCharacterEvents).Action == OnCloseAction.Edit)
            {
                var a = CharacterGrid.Items.Find(x => x.GetItemIndex() == (e as NewCharacterEvents).editedIndex);
            }
            else if ((e as NewCharacterEvents).Action == OnCloseAction.Add)
            {
                CharacterGrid.Items.Add(new CharacterGridItem(character, CharacterGrid.Items.Count + 1));                
            } 
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            CharacterGrid.DrawItens();
        }
        
        public override void onExitclick()
        {            
            this.Close();
            onMdiExitClick();
            this.Dispose();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if(CharacterGrid != null)  CharacterGrid.FillParent(this.ClientRectangle);
        }

        public virtual void onMdiExitClick()
        {            
            var handler = MdiExitClick;
            if (handler != null)
            {
                handler(this, new CharacterEvents(getMdiFormType()));
            }
        }

        public MdiFormType getMdiFormType()
        {
            return MdiFormType.Character;
        }


        public void LoadFromXml(string xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            var chars = doc.DocumentElement.SelectNodes("Character");
            foreach (XmlNode cha in chars)
            {
                var grid = new CharacterGridItem();
                grid.LoadFromXml(cha.OuterXml);
                CharacterGrid.Items.Add(grid);  
            }       
            CharacterGrid.DrawItens();
        }

        public string ToXml()
        {
            XmlDocument xml = new XmlDocument();
            xml.AddRootElement("CharacterForm");
            XmlNode node = xml.CreateElement("Characters");
            foreach (var item in CharacterGrid.Items)
            {
                node.AddXmlNode(item.ToXml());
            }
            xml.AddNode(node);
            return xml.InnerXml;
        }


        public XmlNode ToNodeXml()
        {
            throw new NotImplementedException();
        }
    }

    public class CharacterEvents : EventArgs, IMdiEventArgs
    {
        public MdiFormType FormType { get; set; }
        public CharacterEvents(MdiFormType formType)
        {
            FormType = formType;
        }
    }
}
