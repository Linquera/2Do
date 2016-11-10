using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TwoDoInterfaces;
using TwoDoLanguages;
using TwoDoUtils;

namespace TwoDoCharacter
{
    public class Elements : ITwoDoXml
    {
        private string ROOT = "Elements";
        private CustomXml Xml { get; set; }
        private string ROOTres = "Resistances";
        private CustomXml XmlRes { get; set; }        

        public ElementTypes Element { get; set; }
        public ElementTypes BaseAttack { get; set; }
        public ElementTypes StrongAttack { get; set; }

        public ResistanceType Neutral { get; set; }
        public ResistanceType Psych { get; set; }
        public ResistanceType Fire { get; set; }
        public ResistanceType Water { get; set; }
        public ResistanceType Ice { get; set; }
        public ResistanceType Earth { get; set; }
        public ResistanceType Wind { get; set; }
        public ResistanceType Thunder { get; set; }
        public ResistanceType Ligth { get; set; }
        public ResistanceType Dark { get; set; }
        public ResistanceType Ghost { get; set; }
        public ResistanceType Poison { get; set; }

        public Elements()
        {
            Xml = new CustomXml(ROOT);
            XmlRes = new CustomXml(ROOTres);
            setDefaultResistances();
        }

        private void setDefaultResistances()
        {
            Neutral = ResistanceType.Neutral;
            Psych = ResistanceType.Neutral;
            Fire = ResistanceType.Neutral;
            Water = ResistanceType.Neutral;
            Ice = ResistanceType.Neutral;
            Earth = ResistanceType.Neutral;
            Wind = ResistanceType.Neutral;
            Thunder = ResistanceType.Neutral;
            Ligth = ResistanceType.Neutral;
            Dark = ResistanceType.Neutral;
            Ghost = ResistanceType.Neutral;
            Poison = ResistanceType.Neutral;
        }

        public static string GetElementDescription(ElementTypes element)
        {
            switch (element)
            {
                case ElementTypes.Neutral: return Language.Instance.Neutral;
                case ElementTypes.Fire: return Language.Instance.Fire;
                case ElementTypes.Water: return Language.Instance.Water;
                case ElementTypes.Wind: return Language.Instance.Wind;
                case ElementTypes.Earth: return Language.Instance.Earth;
                case ElementTypes.Ligth: return Language.Instance.Ligth;
                case ElementTypes.Dark: return Language.Instance.Dark;
                case ElementTypes.Poison: return Language.Instance.Poison;
                case ElementTypes.Psych: return Language.Instance.Psych;
                case ElementTypes.Ghost: return Language.Instance.Ghost;
                case ElementTypes.Thunder: return Language.Instance.Thunder;
                case ElementTypes.Ice: return Language.Instance.Ice;
            }
            return string.Empty;
        }

        public static string GetResistanceDescription(ResistanceType resistance)
        {
            switch (resistance)
            {
                case ResistanceType.Absorb: return Language.Instance.Absorb;
                case ResistanceType.Reflect: return Language.Instance.Reflect;
                case ResistanceType.Immunity: return Language.Instance.Immunity;
                case ResistanceType.Res3: return ResistanceType.Res3.GetAttributeOfType<DescriptionAttribute>().Description;
                case ResistanceType.Res2: return ResistanceType.Res2.GetAttributeOfType<DescriptionAttribute>().Description;
                case ResistanceType.Res1: return ResistanceType.Res1.GetAttributeOfType<DescriptionAttribute>().Description;
                case ResistanceType.Neutral: return ResistanceType.Neutral.GetAttributeOfType<DescriptionAttribute>().Description;
                case ResistanceType.Weak1: return ResistanceType.Weak1.GetAttributeOfType<DescriptionAttribute>().Description;
                case ResistanceType.Weak2: return ResistanceType.Weak2.GetAttributeOfType<DescriptionAttribute>().Description;
                case ResistanceType.Weak3: return ResistanceType.Weak3.GetAttributeOfType<DescriptionAttribute>().Description;
                case ResistanceType.Weak4: return ResistanceType.Weak4.GetAttributeOfType<DescriptionAttribute>().Description;
            }
            return string.Empty;
        }

        public void LoadFromXml(string xml)
        {
            if (string.IsNullOrEmpty(xml)) return;
            int aux = 0;
            Xml.LoadXml(xml);
            var node = Xml.SelectSingleNode(ROOT);
            Element = int.TryParse(node.GetNodeStringOrEmpty("Element"), out aux) ? (ElementTypes)aux : ElementTypes.Neutral;
            BaseAttack = int.TryParse(node.GetNodeStringOrEmpty("BaseAttack"), out aux) ? (ElementTypes)aux : ElementTypes.Neutral;
            StrongAttack = int.TryParse(node.GetNodeStringOrEmpty("StrongAttack"), out aux) ? (ElementTypes)aux : ElementTypes.Neutral;

            var resNode = node.SelectSingleNode("Resistances");
            if (resNode != null)
            {
                Neutral = int.TryParse(resNode.GetNodeStringOrEmpty("Neutral"), out aux) ? (ResistanceType)aux : ResistanceType.Neutral;
                Fire = int.TryParse(resNode.GetNodeStringOrEmpty("Fire"), out aux) ? (ResistanceType)aux : ResistanceType.Neutral;
                Water = int.TryParse(resNode.GetNodeStringOrEmpty("Water"), out aux) ? (ResistanceType)aux : ResistanceType.Neutral;
                Wind = int.TryParse(resNode.GetNodeStringOrEmpty("Wind"), out aux) ? (ResistanceType)aux : ResistanceType.Neutral;
                Earth = int.TryParse(resNode.GetNodeStringOrEmpty("Earth"), out aux) ? (ResistanceType)aux : ResistanceType.Neutral;
                Ligth = int.TryParse(resNode.GetNodeStringOrEmpty("Ligth"), out aux) ? (ResistanceType)aux : ResistanceType.Neutral;
                Dark = int.TryParse(resNode.GetNodeStringOrEmpty("Dark"), out aux) ? (ResistanceType)aux : ResistanceType.Neutral;
                Poison = int.TryParse(resNode.GetNodeStringOrEmpty("Poison"), out aux) ? (ResistanceType)aux : ResistanceType.Neutral;
                Psych = int.TryParse(resNode.GetNodeStringOrEmpty("Psych"), out aux) ? (ResistanceType)aux : ResistanceType.Neutral;
                Ghost = int.TryParse(resNode.GetNodeStringOrEmpty("Ghost"), out aux) ? (ResistanceType)aux : ResistanceType.Neutral;
                Thunder = int.TryParse(resNode.GetNodeStringOrEmpty("Thunder"), out aux) ? (ResistanceType)aux : ResistanceType.Neutral;
                Ice = int.TryParse(resNode.GetNodeStringOrEmpty("Ice"), out aux) ? (ResistanceType)aux : ResistanceType.Neutral;
            }            
        }

        private void UpdateXml()
        {
            Xml.Node("Element", ((int)Element).ToString());
            Xml.Node("BaseAttack", ((int)BaseAttack).ToString());
            Xml.Node("StrongAttack", ((int)StrongAttack).ToString());            
            XmlRes.Node("Neutral", ((int)Neutral).ToString());
            XmlRes.Node("Fire", ((int)Fire).ToString());
            XmlRes.Node("Water", ((int)Water).ToString());
            XmlRes.Node("Wind", ((int)Wind).ToString());
            XmlRes.Node("Earth", ((int)Earth).ToString());
            XmlRes.Node("Ligth", ((int)Ligth).ToString());
            XmlRes.Node("Dark", ((int)Dark).ToString());
            XmlRes.Node("Poison", ((int)Poison).ToString());
            XmlRes.Node("Psych", ((int)Psych).ToString());
            XmlRes.Node("Ghost", ((int)Ghost).ToString());
            XmlRes.Node("Thunder", ((int)Thunder).ToString());
            XmlRes.Node("Ice", ((int)Ice).ToString());
            Xml.Node(XmlRes, ROOT);
        }

        public string ToXml()
        {
            UpdateXml();
            return Xml.InnerXml;
        }

        public CustomXml asXml()
        {
            UpdateXml();
            return Xml;
        }
    }
}
