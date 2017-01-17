using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TwoDoInterfaces;
using TwoDoSkill;
using TwoDoUtils;

namespace TwoDoCharacter
{
    public class Character : ICustomGridItemObj
    {
        private string ROOT = "Character";
        public int Index { get; set; }
        public string Name { get; set; }
        public Image Figure { get; set; }
        CustomXml Xml { get; set; }
        public Attributes Attributes { get; set; }
        public Elements Elements { get; set; }
        //public List<Animation> Animations = new List<Animation>(); 
        //public List<Skill> Skills = new List<Skill>();

        public Character()
        {
            Xml = new CustomXml(ROOT);
            Attributes = new Attributes();
            Elements = new Elements();
        }

        public void LoadFromXml(string xml)
        {
            int aux;
            Xml.LoadXml(xml);
            var node = Xml.SelectSingleNode(ROOT);
            Index = int.TryParse(node.GetNodeStringOrEmpty("Index"), out aux) ? aux : 0;
            Name = node.GetNodeStringOrEmpty("Name");
            Figure = Figure.LoadFromString(node.GetNodeStringOrEmpty("Figure"));
            Attributes.LoadFromXml(node.GetNodeXmlOrEmpty("Attributes"));
            Elements.LoadFromXml(node.GetNodeXmlOrEmpty("Elements"));
        }

        private void UpdateXml()
        {            
            Xml.Node("Index", Index.ToString());
            Xml.Node("Name", Name);
            Xml.Node("Figure", Figure != null ? ((Image)Figure.Clone()).ImageToString(): string.Empty);
            Xml.Node(Attributes.asXml(), ROOT);
            Xml.Node(Elements.asXml(), ROOT);
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
    }
}