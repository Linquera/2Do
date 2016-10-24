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
        private string ROOT = "ProjectSave";
        public string Name { get; set; }
        public DateTime LastSave { get; set; }
        private CustomXml Xml { get; set; }

        public ProjectSave()
        {
            Xml = new CustomXml(ROOT);
        }

        public void LoadFromXml(string xml)
        {
            Xml.LoadXml(xml);
            var node = Xml.SelectSingleNode("ProjectSave");
            Name = node.SelectSingleNode("Name").InnerText;
            LastSave = DateTime.ParseExact(node.SelectSingleNode("LastSave").InnerText, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
        }

        private void UpdateXml()
        {
            Xml.Node("Name", Name);
            Xml.Node("LastSave", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
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
