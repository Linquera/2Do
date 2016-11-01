using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using TwoDoInterfaces;
using TwoDoUtils;
using TwoDoCustomForm;

namespace TwoDoCharacter
{
    public class CharacterGridItem : CustomGridItem
    {                
        public Character character;        
        private Label DisplayName = new Label();
        private PictureBox DisplayImage = new PictureBox();        

        public CharacterGridItem() : base()       
        {  }

        public CharacterGridItem(Character character, int index) : this()
        {
            this.character = character;
            character.Index = index;
            setImageConfig();
            setLabelConfig();
        }

        private void setImageConfig()
        {
            DisplayImage.Size = new Size(160, 160);
            DisplayImage.Image = character.Figure;
            DisplayImage.SizeMode = PictureBoxSizeMode.StretchImage;
            DisplayImage.MouseDoubleClick += event_MouseDoubleClick;
            AddComponent(DisplayImage);
        }

        private void setLabelConfig()
        {
            DisplayName.Text = character.Name;
            DisplayName.ForeColor = Color.White;
            DisplayName.Dock = DockStyle.Bottom;
            DisplayName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            DisplayName.MouseDoubleClick += event_MouseDoubleClick;
            AddComponent(DisplayName);           
        }        
        
        private void event_MouseDoubleClick(object sender, MouseEventArgs e)
        {            
            if (this.Parent != null)
            {
                (this.Parent.Parent as ICustomGridHolder).EditableIndex(character.Index);
                (this.Parent.Parent as ICustomGridHolder).EditItem(character.Index);
            }            
        }        

        public string getCharName()
        {
            if (character != null)
	        {
                return character.Name;
	        }
            return "";
        }

        public override int GetItemIndex()
        {
            return character.Index;
        }

        public override void LoadFromXml(string xml)
        {
            character = new Character();
            character.LoadFromXml(xml);
            setImageConfig();
            setLabelConfig();
        }

        public override string ToXml()
        {
            return character.ToXml();
        }

        public override void ReloadDisplay()
        {
            this.DisplayName.Text = this.character.Name;
            this.DisplayImage.Image = character.Figure;
        }

        public override CustomXml asXml()
        {
            return character.asXml();
        }        
    }
}
