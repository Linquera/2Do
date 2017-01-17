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
using TwoDoInterfaces;
using TwoDoUtils;

namespace TwoDoCalcs
{
    public partial class FormulaForm : CustomForm, ITwoDoXml
    {
        private string ROOT = "Formulas";
        private CustomXml Xml { get; set; }
        private FormulaBuilderForm builder { get; set; }

        public FormulaForm() : base(true, true)
        {
            InitializeComponent();
            menuTitle = Language.Instance.CalcFormula;
            this.CenterToParent();
            this.ShowInTaskbar = false;
            setDefaultValues();
            setLanguage();
            setEvents();
            Xml = new CustomXml(ROOT);
        }

        private void setDefaultValues()
        {
            fMinPAtk.DefaultValue = "([STR] * 0.9)";
            fMaxPAtk.DefaultValue = "([STR] * 1.1)";
            fMinMAtk.DefaultValue = "([INT] * 0.5)";
            fMaxMAtk.DefaultValue = "([INT] * 1.5)";
            fPDamage.DefaultValue = "(([MinPAtk]~[MaxPAtk])*(bonusMultipliers) - [EnDef]) * [RES]";
            fMDamage.DefaultValue = "(([MinMAtk]~[MaxMAtk])*(0.5 * [ManaCost]) - [MoMDef]) * [RES]";              
        }

        private void setLanguage()
        {
            fMinPAtk.LabelText = Language.Instance.MinPAtk;
            fMaxPAtk.LabelText = Language.Instance.MaxPAtk;
            fMinMAtk.LabelText = Language.Instance.MinMAtk;
            fMaxMAtk.LabelText = Language.Instance.MaxMAtk;
            fPDamage.LabelText = Language.Instance.PDamage;
            fMDamage.LabelText = Language.Instance.MDamage;
        }

        public void LoadFromXml(string xml)
        {
            Xml.LoadXml(xml);
            var node = Xml.SelectSingleNode(ROOT);
            fMinPAtk.Formula = node.GetNodeStringOrEmpty("MinPAtk");
            fMaxPAtk.Formula = node.GetNodeStringOrEmpty("MaxPAtk");
            fMinMAtk.Formula = node.GetNodeStringOrEmpty("MinMAtk");
            fMaxMAtk.Formula = node.GetNodeStringOrEmpty("MaxMAtk");
            fPDamage.Formula = node.GetNodeStringOrEmpty("PDamage");
            fMDamage.Formula = node.GetNodeStringOrEmpty("MDamage");
        }

        private void UpdateXml()
        {
            Xml.Node("MinPAtk", fMinPAtk.Formula);
            Xml.Node("MaxPAtk", fMinPAtk.Formula);
            Xml.Node("MinMAtk", fMinPAtk.Formula);
            Xml.Node("MaxMAtk", fMinPAtk.Formula);
            Xml.Node("PDamage", fMinPAtk.Formula);
            Xml.Node("MDamage", fMinPAtk.Formula);
        }

        private void setEvents()
        {
            fMinPAtk.OpenEditor = OpenBuilder;
            fMaxPAtk.OpenEditor = OpenBuilder;
            fMinMAtk.OpenEditor = OpenBuilder;
            fMaxMAtk.OpenEditor = OpenBuilder;
            fPDamage.OpenEditor = OpenBuilder;
            fMDamage.OpenEditor = OpenBuilder;
        }

        private void OpenBuilder(object sender, EventArgs e)
        {
            if (builder == null)
            {
                builder = new FormulaBuilderForm();
            }
            builder.ShowDialog();
            ((sender as Control).Parent as CustomFormulaEditor).Formula = builder.Formula;
        }

        public string ToXml()
        {
            return asXml().OuterXml;
        }

        public CustomXml asXml()
        {
            UpdateXml();
            return Xml;
        }

        public override void onExitclick()
        {
            this.Close();
        }
    }
}
