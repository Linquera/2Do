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

namespace TwoDo
{
    public partial class OptionsForm : TwoDoCustomForm.CustomForm
    {
        public OptionsForm() : base(true, true)
        {
            this.MaximumSize = new Size(500, 150);
            InitializeComponent();
            menuTitle = Language.Instance.Options;
            this.CenterToParent();
            this.ShowInTaskbar = false;
            setLanguage();

            gbLanguage.BackColor = Color.FromArgb(40, 40, 40);
            BackGroundColor = Color.FromArgb(40, 40, 40);
            Border.BorderColor = Color.Black;

            btnSave.Text = Language.Instance.Save;
            setButtonsConfig(btnSave);
            btnSave.Click += btnSave_Click;

            FillFields();
        }

        private void FillFields()
        {
            setCheckedLanguage();
        }

        private void setCheckedLanguage()
        {
            switch(Language.StringToLanguage(IniFile.Instance.IniReadValue("Options","Language")))
            {
                case Language.LanguageTypes.English:
                    rbEnglish.Checked = true;
                    break;
                case Language.LanguageTypes.Portuguese:
                    rbPortuguese.Checked = true;
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IniFile.Instance.IniWriteValue("Options", "Language", getLanguage());
            this.Close();
        }

        private string getLanguage()
        {
            if (rbEnglish.Checked)
            {
                return Language.LanguageToString(Language.LanguageTypes.English);
            }
            if (rbPortuguese.Checked)
            {
                return Language.LanguageToString(Language.LanguageTypes.Portuguese);
            }
            return Language.LanguageToString(Language.LanguageTypes.notDefined);
        }

        private void setLanguage()
        {
            rbEnglish.Text = Language.Instance._English;
            rbPortuguese.Text = Language.Instance._Portuguese;
            gbLanguage.Text = Language.Instance._Language;
        }

        public override void onExitclick()
        {
            this.Close();
        }
    }
}
