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
        CustomXml Xml { get; set; }

        public void LoadFromXml(string xml)
        {
            throw new NotImplementedException();
        }

        public string ToXml()
        {
            throw new NotImplementedException();
        }

        public TwoDoUtils.CustomXml asXml()
        {
            throw new NotImplementedException();
        }
    }
}
