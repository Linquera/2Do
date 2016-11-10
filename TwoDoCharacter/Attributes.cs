using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using TwoDoInterfaces;
using TwoDoUtils;

namespace TwoDoCharacter
{
    public class Attributes : IAttributes, ITwoDoXml
    {
        private string ROOT = "Attributes";
        private CustomXml Xml { get; set; }
        public int Strength { get; set; }
        public int Inteligence { get; set; }
        public int Dexterity { get; set; }
        public int Vitality { get; set; }
        public int Luck { get; set; }
        public int BaseHP { get; set; }
        public int BaseMP { get; set; }
        public int MinLevel { get; set; }

        public Attributes()
        {
            Xml = new CustomXml(ROOT);
            Strength = 1;
            Inteligence = 1;
            Dexterity = 1;
            Vitality = 1;
            Luck = 1;
            BaseHP = 100;
            BaseMP = 100;
            MinLevel = 1;
        }

        public void LoadFromXml(string xml)
        {
            if (string.IsNullOrEmpty(xml)) return;
            int aux = 0;
            Xml.LoadXml(xml);
            var node = Xml.SelectSingleNode(ROOT);
            Strength = int.TryParse(node.GetNodeStringOrEmpty("Strength"), out aux) ? aux : 1;
            Inteligence = int.TryParse(node.GetNodeStringOrEmpty("Inteligence"), out aux) ? aux : 1;
            Dexterity = int.TryParse(node.GetNodeStringOrEmpty("Dexterity"), out aux) ? aux : 1;
            Vitality = int.TryParse(node.GetNodeStringOrEmpty("Vitality"), out aux) ? aux : 1;
            Luck = int.TryParse(node.GetNodeStringOrEmpty("Luck"), out aux) ? aux : 1;
            MinLevel = int.TryParse(node.GetNodeStringOrEmpty("MinLevel"), out aux) ? aux : 1;
            BaseHP = int.TryParse(node.GetNodeStringOrEmpty("BaseHP"), out aux) ? aux : 100;
            BaseMP = int.TryParse(node.GetNodeStringOrEmpty("BaseMP"), out aux) ? aux : 100;            
        }        

        private void UpdateXml()
        {
            Xml.Node("Strength", Strength.ToString());
            Xml.Node("Inteligence", Inteligence.ToString());
            Xml.Node("Dexterity", Dexterity.ToString());
            Xml.Node("Vitality", Vitality.ToString());
            Xml.Node("Luck", Luck.ToString());
            Xml.Node("BaseHP", BaseHP.ToString());
            Xml.Node("BaseMP", BaseMP.ToString());
            Xml.Node("MinLevel", MinLevel.ToString());
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
