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
        public ItemForm(bool onlyCloseButton) : base(onlyCloseButton, false)
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
                handler(this, new ItemEvents(getMdiFormType()));
            }
        }

        public MdiFormType getMdiFormType()
        {
            return MdiFormType.Items;
        }
    }

    public class ItemEvents : EventArgs, IMdiEventArgs
    {
        public MdiFormType FormType { get; set; }
        public ItemEvents(MdiFormType formType)
        {
            FormType = formType;
        }
    }
}
