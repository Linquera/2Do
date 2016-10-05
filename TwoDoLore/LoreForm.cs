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

namespace TwoDoLore
{
    public partial class LoreForm : CustomForm, ITwoDoMdiForm
    {
        public event EventHandler MdiExitClick;
        public LoreForm(bool onlyCloseButton) : base(onlyCloseButton, false)
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
                handler(this, new LoreEvents(getMdiFormType()));
            }
        }

        public MdiFormType getMdiFormType()
        {
            return MdiFormType.Lore;
        }
    }

    public class LoreEvents : EventArgs, IMdiEventArgs
    {
        public MdiFormType FormType { get; set; }
        public LoreEvents(MdiFormType formType)
        {
            FormType = formType;
        }
    }
}
