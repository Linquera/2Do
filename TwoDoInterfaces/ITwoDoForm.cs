using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDoInterfaces
{
    public enum MdiFormType { None, Character, Map, Skill, Items, Quest, Lore }
    public enum OnCloseAction { Add, Edit, None }
    
    public interface ITwoDoMdiForm
    {
        event EventHandler MdiExitClick;        
        void onMdiExitClick();
        MdiFormType getMdiFormType();
    }

    public interface ICustomEventArgs { }

    public interface IMdiEventArgs : ICustomEventArgs
    {
        MdiFormType FormType { get; set; }
    }

    public interface IFloatFormEventArgs : ICustomEventArgs
    {
        OnCloseAction Action { get; set; }
    }
}
