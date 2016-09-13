using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDoCustomForm
{
    public class CustomBar
    {
        //color components
        private List<Color> BarColorMix { get; set; }

        //Control Components
        public Color BarGradientColorStart { get; set; }
        public Color BarGradientColorEnd { get; set; }
        public Color BarColor { get; set; }

        public CustomBar()
        {
            BarColorMix = new List<Color>();
            setDefaultCustomColors();              
        }

        private void setDefaultCustomColors()
        {
            // Default Sidebar mix colors:            
            BarColorMix.Add(Color.FromArgb(245, 245, 245));
            BarColorMix.Add(Color.FromArgb(93, 93, 93));
            BarColorMix.Add(Color.FromArgb(45, 45, 45));
            BarColorMix.Add(Color.FromArgb(30, 30, 30));
            BarColorMix.Add(Color.FromArgb(52, 52, 52));

            BarGradientColorStart = Color.FromArgb(52, 52, 52);
            BarGradientColorEnd = Color.FromArgb(52, 52, 52);

            BarColor = Color.FromArgb(52, 52, 52);
        }

        public void RenderBar(Graphics graphics, Rectangle rec)
        {
            GraphicsPath sideBarPath = new GraphicsPath();
            sideBarPath.AddRectangle(rec);
            using (AntiAlias aa = new AntiAlias(graphics))
            {
                RectangleF rcLinearFill = sideBarPath.GetBounds();
                graphics.SetClip(sideBarPath);
                using (LinearGradientBrush lgbLinearFill = new LinearGradientBrush(rcLinearFill, BarGradientColorStart, BarGradientColorEnd, LinearGradientMode.Vertical))
                {

                    graphics.FillRectangle(lgbLinearFill, rcLinearFill);
                }

                graphics.ResetClip();
                DrawSideBarBorder(graphics, rec, Color.FromArgb(0, 0, 0), false);
                DrawSideBarBorder(graphics, rec, BarColor, true);
            }
            sideBarPath.Dispose();
        }

        private void DrawSideBarBorder(Graphics graphics, Rectangle rec, Color color, bool isInnerBorder)
        {
            if (isInnerBorder)
            {
                rec.Inflate(1, 1);
            }
            using (GraphicsPath gp = new GraphicsPath())
            {
                gp.AddRectangle(rec);
                using (Pen border = new Pen(color))
                {
                    graphics.DrawPath(border, gp);
                }
            }
        }
    }
}
