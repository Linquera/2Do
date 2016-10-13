using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDoInterfaces
{
    public interface ICustomGridHolder
    {
        void EditableIndex(int index);
        void EditItem(int index);
    }
}