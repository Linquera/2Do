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
    public class Character : ITwoDoXml
    {
        private string ROOT = "Character";
        public int Index { get; set; }
        public string Name { get; set; }
        public Image Figure { get; set; }
        CustomXml Xml { get; set; }
        public Attributes Attributes { get; set; }
        //public List<Animation> Animations = new List<Animation>(); 
        //public List<Skill> Skills = new List<Skill>();

        public Character()
        {
            Xml = new CustomXml(ROOT);
            Attributes = new Attributes();
        }

        public void LoadFromXml(string xml)
        {
            int aux;
            Xml.LoadXml(xml);
            var node = Xml.SelectSingleNode(ROOT);            
            Index = int.TryParse(node.SelectSingleNode("Index").InnerText, out aux) ? aux : 0;
            Name = node.SelectSingleNode("Name").InnerText;
            Figure = Figure.LoadFromString(node.SelectSingleNode("Figure").InnerText);                
            Attributes.LoadFromXml(node.SelectSingleNode("Attributes").OuterXml);       
        }

        private void UpdateXml()
        {            
            Xml.Node("Index", Index.ToString());
            Xml.Node("Name", Name);
            Xml.Node("Figure", ((Image)Figure.Clone()).ImageToString());
            Xml.Node(Attributes.asXml(), ROOT);
        }

        public string ToXml()
        {        
            UpdateXml();
            return Xml.OuterXml;
        }

        public CustomXml asXml()
        {
            UpdateXml();
            return Xml;
        }
    }
}