using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwoDoCustomForm;
using TwoDoLanguages;

namespace TwoDoCalcs
{
    public partial class FormulaBuilderForm : CustomForm
    {
        private ToolTip tips = new ToolTip();
        public string Formula { get; set; }
        
        public FormulaBuilderForm(): base(true, true)
        {
            this.MaximumSize = new Size(500, 245);
            InitializeComponent();
            Formula = string.Empty;
            menuTitle = Language.Instance.CalcFormula;
            this.CenterToParent();
            this.ShowInTaskbar = false;
            setLanguage();
            ButtonConfig();
            ToolTipConfig();
            setEvents();            
        }

        private void setLanguage()
        {
            //throw new NotImplementedException();
        }

        private void setEvents()
        {
            setTabCharEvents();
            setTabEnemyEvents();

            btnPlus.Click += btn_Click;
            btnDivision.Click += btn_Click;
            btnExp.Click += btn_Click;
            btnLParentesis.Click += btn_Click;
            btnRParentesis.Click += btn_Click;
            btnMinus.Click += btn_Click;
            btnMultiply.Click += btn_Click;
            btnRandom.Click += btn_Click;
            btnOk.Click += btnOk_Click;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidateFormula())
            {
                Formula = txtFormula.Text;
                Close();
            }
            else
            {
                MessageBox.Show("Invalid formula");
            }
        }

        private bool ValidateFormula()
        {
            return true;
            //throw new NotImplementedException();
        }        

        private void setTabCharEvents()
        {
            lblStr.Click += lbl_Click;
            lblInt.Click += lbl_Click;
            lblDex.Click += lbl_Click;
            lblVit.Click += lbl_Click;
            lblLvl.Click += lbl_Click;
        }

        private void setTabEnemyEvents()
        {
            lblEnemyStr.Click += lbl_Click;
            lblEnemyInt.Click += lbl_Click;
            lblEnemyDex.Click += lbl_Click;
            lblEnemyVit.Click += lbl_Click;
            lblEnemyLvl.Click += lbl_Click;
        }

        private void ToolTipConfig()
        {
            tips.SetToolTip(btnPlus, "+");
            tips.SetToolTip(btnDivision, "/");
            tips.SetToolTip(btnExp, "²");
            tips.SetToolTip(btnLParentesis, "(");
            tips.SetToolTip(btnRParentesis, ")");
            tips.SetToolTip(btnMinus, "-");
            tips.SetToolTip(btnMultiply, "*");
            tips.SetToolTip(btnRandom, "~");

            setTabCharTips();
            setTabEnemyTips();
        }

        private void setTabCharTips()
        {
            tips.SetToolTip(lblStr, "STR");
            tips.SetToolTip(lblInt, "INT");
            tips.SetToolTip(lblDex, "DEX");
            tips.SetToolTip(lblVit, "VIT");
            tips.SetToolTip(lblLvl, "LVL");
        }

        private void setTabEnemyTips()
        {
            tips.SetToolTip(lblEnemyStr, "EnSTR");
            tips.SetToolTip(lblEnemyInt, "EnINT");
            tips.SetToolTip(lblEnemyDex, "EnDEX");
            tips.SetToolTip(lblEnemyVit, "EnVIT");
            tips.SetToolTip(lblEnemyLvl, "EnLVL");
        }

        private void ButtonConfig()
        {
            setButtonsConfig(btnDivision);
            setButtonsConfig(btnExp);
            setButtonsConfig(btnLParentesis);
            setButtonsConfig(btnMinus);
            setButtonsConfig(btnMultiply);
            setButtonsConfig(btnOk);
            setButtonsConfig(btnPlus);
            setButtonsConfig(btnRandom);
            setButtonsConfig(btnRParentesis);
        }

        private void lbl_Click(object sender, EventArgs e)
        {
            FillFormula(sender, "[{0}]");
        }

        private void btn_Click(object sender, EventArgs e)
        {
            FillFormula(sender, "{0}");
        }

        private void FillFormula(object obj, string format)
        {
            int position = txtFormula.SelectionStart;
            if ((position == 0) || (txtFormula.Text.Length == position))
            {
                txtFormula.Text += string.Format(format, tips.GetToolTip((obj as Control)));
            }
            else
            {
                string firstPart = txtFormula.Text.Substring(0, position);
                string lastPart = txtFormula.Text.Substring(position, txtFormula.Text.Length - position);
                txtFormula.Text = firstPart + string.Format(format, tips.GetToolTip((obj as Control))) + lastPart;
            }
            txtFormula.SelectionStart = txtFormula.Text.Length;
            txtFormula.Focus();
        }

        public override void onExitclick()
        {
            this.Close();
        }
    }
}
