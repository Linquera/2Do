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
