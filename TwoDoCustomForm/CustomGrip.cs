using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDoCustomForm
{
    public class CustomGrip
    {
        private Color ForeColorStart { get; set; }
        private Color ForeColorEnd { get; set; }
        private Color BackColor { get; set; }

        public CustomGrip()
        {
            ForeColorStart = Color.FromArgb(27, 27, 27);
            ForeColorEnd = Color.FromArgb(27, 27, 27);
            BackColor = Color.FromArgb(48, 48, 48);
        }

        public void DrawSizeGripElement(Graphics graphics, int x, int y)
        {
            Rectangle ForeRect = new Rectangle(x, y, 2, 2);
            Rectangle BackRect = new Rectangle(x + 1, y + 1, 2, 2);

            SolidBrush sbForeStart = new SolidBrush(ForeColorStart);
            SolidBrush sbBack = new SolidBrush(BackColor);

            graphics.FillRectangle(sbBack, BackRect);
            graphics.FillRectangle(sbForeStart, ForeRect);

            ForeRect.Y += 1;
            ForeRect.Height -= 1;
            sbForeStart = new SolidBrush(ForeColorEnd);
            graphics.FillRectangle(sbForeStart, ForeRect);

            sbForeStart.Dispose();
            sbBack.Dispose();
        }
    }
}
