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

namespace TwoDoQuest
{
    public partial class QuestForm : CustomForm, ITwoDoMdiForm
    {
        public event EventHandler MdiExitClick;
        public QuestForm(bool onlyCloseButton) : base(onlyCloseButton)
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
                handler(this, new QuestEvents());
            }
        }

        public MdiFormType getMdiFormType()
        {
            return MdiFormType.Quest;
        }
    }

    public class QuestEvents : EventArgs, ICustomEventArgs
    {
        public MdiFormType getMdiFormType()
        {
            return MdiFormType.Quest;
        }
    }
}
