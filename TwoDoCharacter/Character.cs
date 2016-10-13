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
        public int Index { get; set; }
        public string Name { get; set; }
        public Image Figure { get; set; }
        //public List<Animation> Animations = new List<Animation>(); 
        //public List<Skill> Skills = new List<Skill>();
        public Attributes Attributes = new Attributes();

        public void LoadFromXml(string xml)
        {
            int aux;
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            var node = doc.SelectSingleNode("Character");            
            Index = int.TryParse(node.SelectSingleNode("Index").InnerText, out aux) ? aux : 0;
            Name = node.SelectSingleNode("Name").InnerText;
            Figure = Figure.LoadFromString(node.SelectSingleNode("Figure").InnerText);                
            Attributes.LoadFromXml(node.SelectSingleNode("Attributes").OuterXml);       
        }

        public string ToXml()
        {
            XmlDocument xml = new XmlDocument();
            xml.AddRootElement("Character");
            xml.AddNode("Index", Index.ToString());
            xml.AddNode("Name", Name);
            xml.AddNode("Figure", Figure.ImageToString());
            xml.AddXmlNode("Character", Attributes.ToXml());
            return xml.InnerXml;
        }
    }
}