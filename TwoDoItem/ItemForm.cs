using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwoDoCustomForm;
using TwoDoInterfaces;

namespace TwoDoItem
{
    public partial class ItemForm : CustomForm, ITwoDoMdiForm
    {
        public event EventHandler MdiExitClick;
        public ItemForm(bool onlyCloseButton) : base(onlyCloseButton)
        {
            InitializeComponent();
        }

        public override void onExitclick()
        {
            this.Close();
            onMdiExitClick();
            this.Dispose();
        }

        public virtual void onMdiExitClick()
        {
            var handler = MdiExitClick;
            if (handler != null)
            {
                handler(this, new itemEvents());
            }
        }

        public MdiFormType getMdiFormType()
        {
            return MdiFormType.Items;
        }
    }

    public class itemEvents : EventArgs, ICustomEventArgs
    {
        public MdiFormType getMdiFormType()
        {
            return MdiFormType.Items;
        }
    }
}
