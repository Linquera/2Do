using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using TwoDoInterfaces;

namespace TwoDoCharacter
{
    public class CharacterGridItem : Panel, ICustomGridItem
    {
        private bool inControl = false;        
        public Character character;        
        private Label DisplayName = new Label();
        private PictureBox DisplayImage = new PictureBox();

        private Panel eventCapturer = new Panel();

        public CharacterGridItem()        
        {
            BackColor = Color.FromArgb(65, 65, 65);
            BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;            
        }

        public CharacterGridItem(Character character, int index) : this()
        {
            this.character = character;
            character.Index = index;
            setImageConfig();
            setLabelConfig();
        }

        private void setImageConfig()
        {
            DisplayImage.Size = new Size(160, 160); // todo -make size configurable
            DisplayImage.Image = character.Figure;
            DisplayImage.SizeMode = PictureBoxSizeMode.StretchImage;
            DisplayImage.MouseDoubleClick += event_MouseDoubleClick;
            DisplayImage.MouseDown += event_MouseDown;
            Controls.Add(DisplayImage);
        }

        private void setLabelConfig()
        {
            DisplayName.Text = character.Name;
            DisplayName.ForeColor = Color.White;
            DisplayName.Dock = DockStyle.Bottom;
            DisplayName.TextAlign = ContentAlignment.BottomCenter;
            DisplayName.MouseDoubleClick += event_MouseDoubleClick;
            DisplayName.MouseDown += event_MouseDown;
            Controls.Add(DisplayName);            
        }


        private void event_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.Parent != null && e.Button == MouseButtons.Right)
            {
                (this.Parent.Parent as ICustomGridHolder).EditableIndex(character.Index);
                (this.Parent as ICustomGrid).OpenFloatingMenu(e);  
            }
        }

        private void event_MouseDoubleClick(object sender, MouseEventArgs e)
        {            
            if (this.Parent != null)
            {
                (this.Parent.Parent as ICustomGridHolder).EditableIndex(character.Index);
                (this.Parent.Parent as ICustomGridHolder).EditItem(character.Index);
            }            
        }

        public bool inControls()
        {
            return inControl;
        }

        public void SetToControls()
        {
            inControl = true;
        }

        public void SetSize(Size size)
        {
            this.Size = size;
        }

        public void SetLocation(Point point)
        {
            this.Location = point;
        }

        public string getCharName()
        {
            if (character != null)
	        {
                return character.Name;
	        }
            return "";
        }

        public int GetItemIndex()
        {
            return character.Index;
        }

        public void LoadFromXml(string xml)
        {
            character = new Character();
            character.LoadFromXml(xml);
            setImageConfig();
            setLabelConfig();
        }

        public string ToXml()
        {
            return character.ToXml();
        }

        public void ReloadDisplay()
        {
            this.DisplayName.Text = this.character.Name;
            this.DisplayImage.Image = character.Figure;
        }
    }
}
