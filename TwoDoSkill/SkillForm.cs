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

namespace TwoDoSkill
{
    public partial class SkillForm : CustomForm, ITwoDoMdiForm
    {
        public event EventHandler MdiExitClick;
        public SkillForm(bool onlyCloseButton) : base(onlyCloseButton, false)
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
                handler(this, new SkillEvents(MdiFormType.Skill));
            }
        }

        public MdiFormType getMdiFormType()
        {
            return MdiFormType.Skill;
        }
    }

    public class SkillEvents : EventArgs, IMdiEventArgs
    {
        public MdiFormType FormType { get; set; }

        public SkillEvents(MdiFormType formType)
        {
            FormType = formType;
        }
    }
}
