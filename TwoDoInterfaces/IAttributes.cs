using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDoInterfaces
{
    public interface IAttributes
    {
        int Strength { get; set;}
        int Inteligence{ get; set;}
        int Dexterity { get; set; }
        int Vitality { get; set; }
        int Luck { get; set; }
        int BaseHP { get; set; }
        int BaseMP { get; set; }
        int MinLevel { get; set; }
    }
}
