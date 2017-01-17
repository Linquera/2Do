using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDoInterfaces
{
    public interface ICustomGridItemObj : ITwoDoXml
    {
        int Index { get; set; }
        string Name { get; set; }
        Image Figure { get; set; }
    }
}
