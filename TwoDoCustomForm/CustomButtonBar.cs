using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDoCustomForm
{
    public class CustomButtonBar : CustomBar
    {        
        //Control Components
        private List<CustomButton> buttons = new List<CustomButton>();

        public CustomButtonBar()
        {  }

        public List<CustomButton> Buttons
        {
            get { return buttons; }
        }        

        public void RenderButtonBar(Graphics graphics, Rectangle rec)
        {
            base.RenderBar(graphics, rec);
        }        
    }
}
