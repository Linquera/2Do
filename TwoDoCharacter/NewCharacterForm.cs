using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwoDoInterfaces;

namespace TwoDoCharacter
{
    public partial class NewCharacterForm : TwoDoCustomForm.CustomForm
    {
        public Character character;
        public event EventHandler Save;
        private OnCloseAction Action;
        private int editedIndex = 0;
        private bool advancedOpen { get; set; }
        private Size DefaultSize = new Size(495, 225);
        private Size AdvancedSize = new Size(495, 483);

        public NewCharacterForm() : base(true, true) 
        {            
            this.MaximumSize = DefaultSize;
            advancedOpen = false;
            menuTitle = "New Character";
            InitializeComponent();
            setButtonEvents();
            LoadEvents();
            picChar.SizeMode = PictureBoxSizeMode.StretchImage;
            Action = OnCloseAction.Add;            
            this.CenterToParent();
            this.ShowInTaskbar = false;
        }              

        public NewCharacterForm(Character Char, int index) : this()
        {
            character = Char;            
            LoadFormInfo();
            Action = OnCloseAction.Edit;
            editedIndex = index;
        }

        private void setButtonEvents()
        {
            btnAdvanced.Click += Advanced_click;
            setButtonsConfig(btnAdvanced);

            btnAdd.Click += Add_click;
            setButtonsConfig(btnAdd);

            btnSelectImg.Click += SelectImg_click;
            setButtonsConfig(btnSelectImg);
        }  

        private void setButtonsConfig(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 1;
            button.FlatAppearance.BorderColor = Color.Black;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, 150, 150);
            button.BackColor = Color.FromArgb(190, 190, 190);
            button.ForeColor = Color.Black;     
        }

        private void LoadEvents()
        {            
            txtBaseHP.KeyPress += NumebersOnly;
            txtBaseMP.KeyPress += NumebersOnly;
            txtDex.KeyPress += NumebersOnly;
            txtInt.KeyPress += NumebersOnly;
            txtLuck.KeyPress += NumebersOnly;
            txtMinLevel.KeyPress += NumebersOnly;
            txtStr.KeyPress += NumebersOnly;
            txtVit.KeyPress += NumebersOnly;            
        }

        private void Advanced_click(object sender, EventArgs e)
        {
            if (advancedOpen)
            {
                this.MaximumSize = DefaultSize;
                advancedOpen = false;
            }
            else
            {
                this.MaximumSize = AdvancedSize;
                this.Size = AdvancedSize;
                advancedOpen = true;
            }
        }

        private void Add_click(object sender, EventArgs e)
        {
            int aux = 0;
            if (character == null) character = new Character();
            character.Name = txtName.Text;
            character.Attributes.BaseHP = int.TryParse(txtBaseHP.Text, out aux) ? aux : 100;
            character.Attributes.BaseMP = int.TryParse(txtBaseMP.Text, out aux) ? aux : 100;
            character.Attributes.Dexterity = int.TryParse(txtDex.Text, out aux) ? aux : 1; 
            character.Attributes.Inteligence = int.TryParse(txtInt.Text, out aux) ? aux : 1;
            character.Attributes.Luck = int.TryParse(txtLuck.Text, out aux) ? aux : 1;
            character.Attributes.MinLevel = int.TryParse(txtMinLevel.Text, out aux) ? aux : 1;
            character.Attributes.Strength = int.TryParse(txtStr.Text, out aux) ? aux : 1;
            character.Attributes.Vitality = int.TryParse(txtVit.Text, out aux) ? aux : 1;
            character.Figure = picChar.Image;
            onSave();
        }

        public virtual void onSave()
        {
            var handler = Save;
            if (handler != null)
            {
                handler(this, new NewCharacterEvents(Action) { editedIndex = editedIndex });
            }
            this.Close();
        }

        private void LoadFormInfo()
        {
            txtName.Text = character.Name;
            txtBaseHP.Text = character.Attributes.BaseHP.ToString();
            txtBaseMP.Text = character.Attributes.BaseMP.ToString();
            txtDex.Text = character.Attributes.Dexterity.ToString();
            txtInt.Text = character.Attributes.Inteligence.ToString();
            txtLuck.Text = character.Attributes.Luck.ToString();
            txtMinLevel.Text = character.Attributes.MinLevel.ToString();
            txtStr.Text = character.Attributes.Strength.ToString();
            txtVit.Text = character.Attributes.Vitality.ToString();
            picChar.Image = character.Figure;
        }

        private void SelectImg_click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Select Image";
                dlg.Filter = "Image Files (.jpeg, .png, .jpg, .gif)|*.jpeg;*.png;*.jpg;*.gif";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    picChar.Image = new Bitmap(dlg.FileName);
                }
            }
        }

        public override void onExitclick()
        {
            this.Close();
        }
    }

    public class NewCharacterEvents : EventArgs, IFloatFormEventArgs
    {
        public OnCloseAction Action { get; set; }
        public int editedIndex { get; set; }
        public NewCharacterEvents(OnCloseAction action)
        {
            Action = action;
        }
    }
}
