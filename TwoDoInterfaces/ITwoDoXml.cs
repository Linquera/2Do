using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TwoDoUtils;

namespace TwoDoInterfaces
{
    public interface ITwoDoXml
    {
        void LoadFromXml(string xml);
        string ToXml();
        CustomXml asXml();
    }
}
