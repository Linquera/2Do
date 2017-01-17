using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoDoInterfaces;
using TwoDoUtils;

namespace TwoDoItem
{
    public class Obtain : ITwoDoXml
    {
        private string ROOT = "Obtain";
        public bool MonsterDrop { get; set; }
        public bool Quest { get; set; }
        public bool TreasureBox { get; set; }
        public bool OnGround { get; set; }
        public bool StoryLine { get; set; }
        public bool Craft { get; set; }
        public bool Event { get; set; }
        public bool NotObtainable { get; set; }
        CustomXml Xml { get; set; }

        public Obtain()
        {
            Xml = new CustomXml(ROOT);
            MonsterDrop = false;
            Quest = false;
            TreasureBox = false;
            OnGround = false;
            StoryLine = false;
            Craft = false;
            Event = false;
            NotObtainable = false;
        }

        public void LoadFromXml(string xml)
        {
            int aux = 0;
            if (string.IsNullOrEmpty(xml)) return;
            Xml.LoadXml(xml);
            var node = Xml.SelectSingleNode(ROOT);
            MonsterDrop = int.TryParse(node.GetNodeStringOrEmpty("MonsterDrop"), out aux) ? (aux == 1 ? true : false) : false;
            Quest = int.TryParse(node.GetNodeStringOrEmpty("Quest"), out aux) ? (aux == 1 ? true : false) : false;
            TreasureBox = int.TryParse(node.GetNodeStringOrEmpty("TreasureBox"), out aux) ? (aux == 1 ? true : false) : false;
            OnGround = int.TryParse(node.GetNodeStringOrEmpty("OnGround"), out aux) ? (aux == 1 ? true : false) : false;
            StoryLine = int.TryParse(node.GetNodeStringOrEmpty("StoryLine"), out aux) ? (aux == 1 ? true : false) : false;
            Craft = int.TryParse(node.GetNodeStringOrEmpty("Craft"), out aux) ? (aux == 1 ? true : false) : false;
            Event = int.TryParse(node.GetNodeStringOrEmpty("Event"), out aux) ? (aux == 1 ? true : false) : false;
            NotObtainable = int.TryParse(node.GetNodeStringOrEmpty("NotObtainable"), out aux) ? (aux == 1 ? true : false) : false;
        }

        private void UpdateXml()
        {
            Xml.Node("MonsterDrop", (MonsterDrop ? "1" : "0"));
            Xml.Node("Quest", (Quest ? "1" : "0"));
            Xml.Node("TreasureBox", (TreasureBox ? "1" : "0"));
            Xml.Node("OnGround", (OnGround ? "1" : "0"));
            Xml.Node("StoryLine", (StoryLine ? "1" : "0"));
            Xml.Node("Craft", (Craft ? "1" : "0"));
            Xml.Node("Event", (Event ? "1" : "0"));
            Xml.Node("NotObtainable", (NotObtainable ? "1" : "0"));
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
