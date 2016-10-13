using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TwoDoInterfaces;
using TwoDoUtils;

namespace TwoDo
{
    public class ProjectSave : ITwoDoXml
    {
        public string Name { get; set; }
        public DateTime LastSave { get; set; }

        public void LoadFromXml(string xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            var node = doc.SelectSingleNode("ProjectSave");
            Name = node.SelectSingleNode("Name").InnerText;
            LastSave = DateTime.ParseExact(node.SelectSingleNode("LastSave").InnerText, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
        }

        public string ToXml()
        {
            XmlDocument xml = new XmlDocument();
            xml.AddRootElement("ProjectSave");
            xml.AddNode("Name", Name);
            xml.AddNode("LastSave", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));      
            return xml.InnerXml;
        }
    }
}
