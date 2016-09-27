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

namespace TwoDoCharacter
{
    public partial class CharacterForm : CustomForm, ITwoDoMdiForm
    {
        public event EventHandler MdiExitClick;
        public CharacterForm(bool onlyCloseButton) : base(onlyCloseButton)
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
                handler(this, new CharacterEvents());
            }
        }

        public MdiFormType getMdiFormType()
        {
            return MdiFormType.Character;
        }

    }

    public class CharacterEvents : EventArgs, ICustomEventArgs
    {
        public MdiFormType getMdiFormType()
        {
            return MdiFormType.Character;
        }
    }
}
