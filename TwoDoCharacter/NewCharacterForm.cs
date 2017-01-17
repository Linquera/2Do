using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwoDoLanguages;
using TwoDoUtils;
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
        private Size defaultSize = new Size(495, 225);
        private Size AdvancedSize = new Size(495, 450);
        private ToolTip tips = new ToolTip();

        public NewCharacterForm() : base(true, true)
        {            
            this.MaximumSize = defaultSize;
            advancedOpen = false;
            menuTitle = Language.Instance.NewCharacter;
            InitializeComponent();
            setButtonEvents();
            LoadEvents();
            picChar.SizeMode = PictureBoxSizeMode.StretchImage;
            Action = OnCloseAction.Add;
            
            setElementsConfig();
            TabElements.BackColor = this.BackColor;
            this.CenterToParent();
            this.ShowInTaskbar = false;
            setLanguage();
            setTips();
            FillComboBox();
        }

        public NewCharacterForm(Character Char, int index) : this()
        {
            character = Char;
            LoadFormInfo();
            Action = OnCloseAction.Edit;
            editedIndex = index;
        }

        private void FillComboBox()
        {
            FillComboBoxWithElementEnum(cbBaseAttack);
            FillComboBoxWithElementEnum(cbStrongAttack);
            FillComboBoxWithElementEnum(cbBaseElement);
            FillComboBoxWithResistanceEnum(cbFireRes);
            FillComboBoxWithResistanceEnum(cbWaterRes);
            FillComboBoxWithResistanceEnum(cbWindRes);
            FillComboBoxWithResistanceEnum(cbEarthRes);
            FillComboBoxWithResistanceEnum(cbLigthRes);
            FillComboBoxWithResistanceEnum(cbDarkRes);
            FillComboBoxWithResistanceEnum(cbIceRes);
            FillComboBoxWithResistanceEnum(cbThunderRes);
            FillComboBoxWithResistanceEnum(cbPsyRes);
            FillComboBoxWithResistanceEnum(cbGhostRes);
            FillComboBoxWithResistanceEnum(cbPoisonRes);
            FillComboBoxWithResistanceEnum(cbNeutralRes);
        }

        private void FillComboBoxWithResistanceEnum(ComboBox cbox)
        {
            var resistances = Enum.GetValues(typeof(ResistanceType)).Cast<ResistanceType>();
            foreach (var resistance in resistances)
            {
                cbox.Items.Add(resistance.GetDescription());
            }
            cbox.SelectedIndex = (int)ResistanceType.Neutral;
        }


        private void FillComboBoxWithElementEnum(ComboBox cbox)
        {
            var elements = Enum.GetValues(typeof(ElementTypes)).Cast<ElementTypes>();
            foreach (var element in elements)
            {
                cbox.Items.Add(element.GetDescription());
            }
            cbox.SelectedIndex = (int)ElementTypes.Neutral;
        }        

        private void setElementsConfig()
        {
            pbFire.Image = TwoDoCharacter.Properties.Resources.Fire;            
            configPicBox(pbFire);

            pbWater.Image = TwoDoCharacter.Properties.Resources.Water;
            configPicBox(pbWater);

            pbWind.Image = TwoDoCharacter.Properties.Resources.Wind;
            configPicBox(pbWind);

            pbEarth.Image = TwoDoCharacter.Properties.Resources.Earth;
            configPicBox(pbEarth);

            pbLigth.Image = TwoDoCharacter.Properties.Resources.Ligth;
            configPicBox(pbLigth);

            pbDark.Image = TwoDoCharacter.Properties.Resources.Dark;
            configPicBox(pbDark);

            pbPsych.Image = TwoDoCharacter.Properties.Resources.Psych;
            configPicBox(pbPsych);

            pbThunder.Image = TwoDoCharacter.Properties.Resources.Thunder;
            configPicBox(pbThunder);

            pbIce.Image = TwoDoCharacter.Properties.Resources.Ice;
            configPicBox(pbIce);

            pbGhost.Image = TwoDoCharacter.Properties.Resources.Ghost;
            configPicBox(pbGhost);

            pbPoison.Image = TwoDoCharacter.Properties.Resources.Posion;
            configPicBox(pbPoison);

            pbNeutral.Image = TwoDoCharacter.Properties.Resources.Neutral;
            configPicBox(pbNeutral);  
        }

        private void setTips()
        {
            tips.SetToolTip(pbNeutral, Language.Instance.Neutral);
            tips.SetToolTip(pbFire, Language.Instance.Fire);
            tips.SetToolTip(pbWater, Language.Instance.Water);
            tips.SetToolTip(pbWind, Language.Instance.Wind);
            tips.SetToolTip(pbEarth, Language.Instance.Earth);
            tips.SetToolTip(pbThunder, Language.Instance.Thunder);
            tips.SetToolTip(pbIce, Language.Instance.Ice);
            tips.SetToolTip(pbLigth, Language.Instance.Ligth);
            tips.SetToolTip(pbDark, Language.Instance.Dark);
            tips.SetToolTip(pbGhost, Language.Instance.Ghost);
            tips.SetToolTip(pbPoison, Language.Instance.Poison);
            tips.SetToolTip(pbPsych, Language.Instance.Psych);
        }

        private void configPicBox(PictureBox picBox)
        {
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            picBox.BorderStyle = BorderStyle.None;            
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

        private void setLanguage()
        {
            lblBaseHp.Text = Language.Instance.BaseHP;
            lblBaseMp.Text = Language.Instance.BaseMP;
            lblStrength.Text = Language.Instance.Strength;
            lblDexterity.Text = Language.Instance.Dexterity;
            lblInteligence.Text = Language.Instance.Inteligence;
            lblLuck.Text = Language.Instance.Luck;
            lblMinLevel.Text = Language.Instance.MinLevel;
            lblVitality.Text = Language.Instance.Vitality;
            lblName.Text = Language.Instance.Name;
            btnAdd.Text = Language.Instance.Add;
            btnAdvanced.Text = Language.Instance.Advanced;
            btnSelectImg.Text = Language.Instance.SelectImage;
        } 

        private void Advanced_click(object sender, EventArgs e)
        {
            if (advancedOpen)
            {
                this.MaximumSize = defaultSize;
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
            UpdateCharacter();
            onSave();
        }

        private void UpdateCharacter()
        {
            int aux = 0;
            if (character == null) character = new Character();
            character.Name = txtName.Text;
            character.Figure = picChar.Image;
            //attributes
            character.Attributes.BaseHP = int.TryParse(txtBaseHP.Text, out aux) ? aux : 100;
            character.Attributes.BaseMP = int.TryParse(txtBaseMP.Text, out aux) ? aux : 100;
            character.Attributes.Dexterity = int.TryParse(txtDex.Text, out aux) ? aux : 1;
            character.Attributes.Inteligence = int.TryParse(txtInt.Text, out aux) ? aux : 1;
            character.Attributes.Luck = int.TryParse(txtLuck.Text, out aux) ? aux : 1;
            character.Attributes.MinLevel = int.TryParse(txtMinLevel.Text, out aux) ? aux : 1;
            character.Attributes.Strength = int.TryParse(txtStr.Text, out aux) ? aux : 1;
            character.Attributes.Vitality = int.TryParse(txtVit.Text, out aux) ? aux : 1;

            //elements
            character.Elements.Element = (ElementTypes)cbBaseElement.SelectedIndex;
            character.Elements.BaseAttack = (ElementTypes)cbBaseAttack.SelectedIndex;
            character.Elements.StrongAttack = (ElementTypes)cbStrongAttack.SelectedIndex;
            character.Elements.Fire = (ResistanceType)cbFireRes.SelectedIndex;
            character.Elements.Water = (ResistanceType)cbWaterRes.SelectedIndex;
            character.Elements.Wind = (ResistanceType)cbWindRes.SelectedIndex;
            character.Elements.Earth = (ResistanceType)cbEarthRes.SelectedIndex;
            character.Elements.Ice = (ResistanceType)cbIceRes.SelectedIndex;
            character.Elements.Thunder = (ResistanceType)cbThunderRes.SelectedIndex;
            character.Elements.Ghost = (ResistanceType)cbGhostRes.SelectedIndex;
            character.Elements.Psych = (ResistanceType)cbPsyRes.SelectedIndex;
            character.Elements.Poison = (ResistanceType)cbPoisonRes.SelectedIndex;
            character.Elements.Neutral = (ResistanceType)cbNeutralRes.SelectedIndex;
            character.Elements.Ligth = (ResistanceType)cbLigthRes.SelectedIndex;
            character.Elements.Dark = (ResistanceType)cbDarkRes.SelectedIndex;    
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

            cbBaseElement.SelectedIndex = (int)character.Elements.Element;
            cbBaseAttack.SelectedIndex = (int)character.Elements.BaseAttack;
            cbStrongAttack.SelectedIndex = (int)character.Elements.StrongAttack;
            cbFireRes.SelectedIndex = (int)character.Elements.Fire;
            cbWaterRes.SelectedIndex = (int)character.Elements.Water;
            cbWindRes.SelectedIndex = (int)character.Elements.Wind;
            cbEarthRes.SelectedIndex = (int)character.Elements.Earth;
            cbIceRes.SelectedIndex = (int)character.Elements.Ice;
            cbThunderRes.SelectedIndex = (int)character.Elements.Thunder;
            cbGhostRes.SelectedIndex = (int)character.Elements.Ghost;
            cbPsyRes.SelectedIndex = (int)character.Elements.Psych;
            cbPoisonRes.SelectedIndex = (int)character.Elements.Poison;
            cbNeutralRes.SelectedIndex = (int)character.Elements.Neutral;
            cbLigthRes.SelectedIndex = (int)character.Elements.Ligth;
            cbDarkRes.SelectedIndex = (int)character.Elements.Dark; 
        }

        private void SelectImg_click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = Language.Instance.SelectImage;
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
