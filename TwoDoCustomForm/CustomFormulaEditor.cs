using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoDoCustomForm
{
    public partial class CustomFormulaEditor : UserControl
    {
        [Description("LabelText"), Category("Data")]
        public string LabelText
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }
        [Description("Formula"), Category("Data")]
        public string Formula
        {
            get { return TxtFormula.Text; }
            set { TxtFormula.Text = value; }
        }
        [Description("DefaultValue"), Category("Data")]
        public string DefaultValue 
        {
            get { return defaultValue; }
            set 
            {
                defaultValue = value;
                Formula = DefaultValue;
            } 
        }
        public EventHandler OpenEditor { set { btnEditor.Click += value; } }        
        private string defaultValue;

        public CustomFormulaEditor()
        {
            InitializeComponent();
            TxtFormula.Leave += TxtFormula_Leave;
            lblName.ForeColor = Color.White;
        }

        private void TxtFormula_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtFormula.Text))
            {
                TxtFormula.Text = DefaultValue;
            }	
        }
        
    }
}
