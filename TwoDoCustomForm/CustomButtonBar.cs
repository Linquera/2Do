using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoDoCustomForm
{
    public class CustomButtonBar : CustomBar
    {        
        //Control Components
        private List<Button> buttons = new List<Button>();
        public bool ButtonFillWholeBar = false;
        public int ButtonHeigth { get; set; }
        public int ButtonWidth { get; set; }
        public int ButtonTopDownOffSet { get; set; }
        public int ButtonSideOffSet { get; set; }
        
        //Button Colors
        private Color ButtonColor { get; set; }
        private Color ButtonFontColor { get; set; }

        public CustomButtonBar()
        { 
            ButtonColor = Color.FromArgb(50, 50, 50);
            ButtonFontColor = Color.FromArgb(250, 250, 250);
            ButtonHeigth = 32;
            ButtonWidth = 32;
            ButtonTopDownOffSet = 2;
            ButtonSideOffSet = 2;
        }

        public List<Button> Buttons
        {
            get { return buttons; }
        }

        public void RenderButtonBar(Graphics graphics, Rectangle rec)
        {
            base.RenderBar(graphics, rec);
            if (buttons.Count > 0)
            {
                SetButtonsConfigs(rec);
            }
        }

        private void SetButtonsConfigs(Rectangle rec)
        {
            bool vertical = rec.Height > rec.Width;
            int height = ButtonHeigth;
            int width = ButtonWidth;
            int x = rec.X;
            int y = rec.Y;
            if (ButtonFillWholeBar)
            {
                height = vertical ? rec.Height / buttons.Count : rec.Height;
                width = vertical ? rec.Width : rec.Width / buttons.Count;
            }
            foreach (var button in buttons)
            {
                //Positioning
                button.Location = new Point(x + ButtonSideOffSet, y + ButtonTopDownOffSet);
                button.Height = height - ButtonTopDownOffSet;
                button.Width = width - ButtonSideOffSet;

                if (vertical) { y += height; }
                else { x += width; }

                //painting
                button.BackColor = ButtonColor;                
                button.ForeColor = ButtonFontColor;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.ImageAlign = ContentAlignment.MiddleCenter;
                button.TextAlign = ContentAlignment.BottomCenter;
            }
        }        
    }
}
