using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoDoInterfaces;
using TwoDoUtils;

namespace TwoDoItem
{
    public class Item : ICustomGridItemObj
    {
        private string ROOT = "Item";
        public int Index { get; set; }
        public string Name { get; set; }
        public Image Figure { get; set; }
        public ItemCategoryType Category { get; set; }
        public Obtain Obtain { get; set; }
        CustomXml Xml { get; set; }

        public Item() 
        {
            Xml = new CustomXml(ROOT);
            Obtain = new Obtain();
        }

        public void LoadFromXml(string xml)
        {
            int aux;
            Xml.LoadXml(xml);
            var node = Xml.SelectSingleNode(ROOT);
            Index = int.TryParse(node.GetNodeStringOrEmpty("Index"), out aux) ? aux : 0;
            Name = node.GetNodeStringOrEmpty("Name");
            Figure = Figure.LoadFromString(node.GetNodeStringOrEmpty("Figure"));
            Obtain.LoadFromXml(node.GetNodeXmlOrEmpty("Obtain"));
            Category = int.TryParse(node.GetNodeStringOrEmpty("Category"), out aux) ? (ItemCategoryType)aux : ItemCategoryType.Loot;
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

        private void UpdateXml()
        {
            Xml.Node("Index", Index.ToString());
            Xml.Node("Name", Name);
            Xml.Node("Figure", Figure != null ? ((Image)Figure.Clone()).ImageToString() : string.Empty);
            Xml.Node("Category", ((int)Category).ToString());
            Xml.Node(Obtain.asXml(), ROOT);
        }
    }    
}
