using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDoInterfaces
{
    public enum MdiFormType { None, Character, Map, Skill, Items, Quest, Lore }
    
    public interface ITwoDoMdiForm
    {        
        void onMdiExitClick();
        MdiFormType getMdiFormType();
    }

    public interface ICustomEventArgs
    {
        MdiFormType getMdiFormType();
    }
}
