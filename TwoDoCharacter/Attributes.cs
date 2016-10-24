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
            Xml = new CustomXml("Attributes");
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
            int aux = 0;
            Xml.LoadXml(xml);
            var nodes = Xml.SelectNodes("Attributes");
            foreach (XmlNode node in nodes)
            {
                Strength = int.TryParse(node.SelectSingleNode("Strength").InnerText, out aux) ? aux : 1;
                Inteligence = int.TryParse(node.SelectSingleNode("Inteligence").InnerText, out aux) ? aux : 1;
                Dexterity = int.TryParse(node.SelectSingleNode("Dexterity").InnerText, out aux) ? aux : 1;
                Vitality = int.TryParse(node.SelectSingleNode("Vitality").InnerText, out aux) ? aux : 1;
                Luck = int.TryParse(node.SelectSingleNode("Luck").InnerText, out aux) ? aux : 1;
                MinLevel = int.TryParse(node.SelectSingleNode("MinLevel").InnerText, out aux) ? aux : 1;
                BaseHP = int.TryParse(node.SelectSingleNode("BaseHP").InnerText, out aux) ? aux : 100;
                BaseMP = int.TryParse(node.SelectSingleNode("BaseMP").InnerText, out aux) ? aux : 100;
            }
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
