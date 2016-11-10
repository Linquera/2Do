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
using TwoDoLanguages;

namespace TwoDoCharacter
{
    public partial class CharacterForm : CustomForm, ITwoDoMdiForm, ITwoDoXml, ICustomGridHolder
    {
        public static string Root = "CharacterForm";        
        private NewCharacterForm newCharForm;
        private ToolStripMenuItem editMenuItem;
        private ToolStripMenuItem deleteMenuItem;
        private int currentIndexEdit = 0;
        private CustomXml Xml { get; set; }

        public event EventHandler MdiExitClick;
        public CustomGridPanel CharacterGrid;
       
        public CharacterForm(bool onlyCloseButton) : base(onlyCloseButton, false)
        {            
            InitializeComponent();
            MainMenuBar.BarColor = Color.FromArgb(70,70,70);
            MainMenuBar.BarGradientColorStart = Color.FromArgb(70, 70, 70);
            MainMenuBar.BarGradientColorEnd = Color.FromArgb(70, 70, 70);
            Xml = new CustomXml(Root);
            menuTitle = Language.Instance.Character;
            CharacterGrid = new CustomGridPanel(this.ClientRectangle);
            CharacterGrid.Padding = new Padding(1,1,0, 30);
            setFloatMenuConfig();
            this.Controls.Add(CharacterGrid);            
        }

        private void setFloatMenuConfig()
        {
            CharacterGrid.FloatingMenu.Items.Add(new ToolStripMenuItem(Language.Instance.NewCharacter, null, newCharacter_click));            
            editMenuItem = new ToolStripMenuItem(Language.Instance.Edit, null, Edit_click);
            editMenuItem.Visible = false;
            CharacterGrid.FloatingMenu.Items.Add(editMenuItem);
            deleteMenuItem = new ToolStripMenuItem(Language.Instance.Delete, null, Delete_click);
            deleteMenuItem.Visible = false;
            CharacterGrid.FloatingMenu.Items.Add(deleteMenuItem);
            CharacterGrid.FloatingMenu.Items.Add(new ToolStripMenuItem(Language.Instance.Sort, null, Sort_click));
            CharacterGrid.FloatingMenu.Closed += FloatingMenu_Closing;
        }

        private void Delete_click(object sender, EventArgs e)
        {
            var delete = (CharacterGrid.Items.Find(x => x.GetItemIndex() == currentIndexEdit));
            if (MessageBox.Show(string.Format("{0} \"{1}\" ?", Language.Instance.Delete, (delete as CustomImageGridItem).item.Name), 
                "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                CharacterGrid.RemoveItem(delete);                
            }
        }

        private void FloatingMenu_Closing(object sender, EventArgs e)
        {
            editMenuItem.Visible = false;
            deleteMenuItem.Visible = false;
        }

        private void Edit_click(object sender, EventArgs e)
        {
            EditChar();
        }

        private void EditChar()
        {
            Character edit = ((CharacterGrid.Items.Find(x => x.GetItemIndex() == currentIndexEdit) as CustomImageGridItem).item as Character);
            newCharForm = new NewCharacterForm(edit, currentIndexEdit);
            newCharForm.Save += newCharForm_Save;
            newCharForm.ShowDialog();
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

        public void newCharForm_Save(object sender, EventArgs e)
        {
            var character = (sender as NewCharacterForm).character;
            if ((e as NewCharacterEvents).Action == OnCloseAction.Edit)
            {
                var griditem = (CharacterGrid.Items.Find(x => x.GetItemIndex() == (e as NewCharacterEvents).editedIndex) as CustomImageGridItem);
                griditem.ReloadDisplay();
            }  
            else if ((e as NewCharacterEvents).Action == OnCloseAction.Add)
            {
                CharacterGrid.Items.Add(new CustomImageGridItem(character, CharacterGrid.Items.Count + 1));                
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
            Xml.LoadXml(xml);
            var chars = Xml.DocumentElement.SelectNodes("Characters/Character");
            foreach (XmlNode cha in chars)
            {
                var grid = new CustomImageGridItem();
                grid.LoadFromXml(new Character(), cha.OuterXml);
                CharacterGrid.Items.Add(grid);  
            }       
            CharacterGrid.DrawItens();
        }

        public string ToXml()
        {
            return asXml().InnerXml;
        }

        public void EditableIndex(int index)
        {      
            editMenuItem.Visible = true;
            deleteMenuItem.Visible = true;
            currentIndexEdit = index;   
        }

        public void EditItem(int index)
        {
            currentIndexEdit = index;
            EditChar();
        }

        public CustomXml asXml()
        {
            CustomXml innerXml = new CustomXml("Characters");
            foreach (var item in CharacterGrid.Items)
            {
                innerXml.Node(item.asXml());
            }            
            Xml.Node(innerXml,Root);
            return Xml;
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
