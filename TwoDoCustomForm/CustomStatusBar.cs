using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDoCustomForm
{
    public class CustomStatusBar
    {
        public int BarHeight{ get; set;}
        public Color StatusColorStart { get; set; }
        public Color StatusColorEnd { get; set; }
        public Color StatusSeparatorUpColor { get; set; }
        public Color GlowColor { get; set; }
        public Color BorderColor { get; set; }
        public bool EllipticalGlow { get; set; }
        public Rectangle Grip { get; set; }

        private CustomGrip customGrip = new CustomGrip(); 
        private List<CustomBarItem> barItems = new List<CustomBarItem>();

        public CustomStatusBar()
        {
            setDefaultValues();            
        }

        public List<CustomBarItem> BarItems
        {
            get { return barItems; }
        }

        private void setDefaultValues()
        {
            BarHeight = 22;
            StatusColorStart = Color.FromArgb(40, 40, 40);
            StatusColorEnd = Color.FromArgb(35, 35, 35);
            StatusSeparatorUpColor = Color.FromArgb(27, 27, 27);
            GlowColor = Color.FromArgb(80, 80, 80);
            BorderColor = Color.FromArgb(27, 27, 27);
            EllipticalGlow = true;
        }

        public void RenderStatusBar(Graphics graphics, int x, int y, int width, int height)
        {    
            //Drawing the status bar
            Rectangle rcStatus = new Rectangle(x, y, width, height);
            using (LinearGradientBrush lgb = new LinearGradientBrush(rcStatus, StatusColorStart, StatusColorEnd, LinearGradientMode.Vertical))
            {
                graphics.FillRectangle(lgb, rcStatus);
            }

            //Drawing the separation lines
            Pen pUp = new Pen(StatusSeparatorUpColor);
            graphics.DrawLine(pUp, x, rcStatus.Bottom, rcStatus.Right, rcStatus.Bottom );

            //Render componentes            
            int _Left = rcStatus.Left;
            foreach (CustomBarItem item in BarItems)
            {
                item.RenderBarItem(graphics, _Left, rcStatus.Top);
                _Left += item.Width;
            }
            
            DrawStatusGlow(rcStatus, graphics, GlowColor);
            
            // Render size grip
            Grip = new Rectangle(rcStatus.Right - 22, rcStatus.Bottom - 10, 10, 11);
            
            int _x = Grip.Left;
            int _y = Grip.Top + 2;
            for (int i = 0; i < 4; i++)
            {
                if (i == 3)
                {
                    _x -= 4;
                    for (int j = 0; j < 2; j++)
                    {
                        _y -= 4;
                        customGrip.DrawSizeGripElement(graphics, _x, _y);
                        if (j == 1)
                        {
                            _y += 4;
                            _x -= 4;
                            customGrip.DrawSizeGripElement(graphics, _x, _y);
                        }

                    }
                }
                else
                {
                    customGrip.DrawSizeGripElement(graphics, _x, _y);
                    _x += 4;
                }
            }

            //Draw border
            using (Pen pBorder = new Pen(BorderColor))
            {
                graphics.DrawRectangle(pBorder, rcStatus);
            }

            pUp.Dispose();            
        }

        private void DrawStatusGlow(Rectangle rect, Graphics graphics, Color glowColor)
        {
            Rectangle rcGlow = rect;
            using (LinearGradientBrush glow = new LinearGradientBrush(rcGlow, Color.FromArgb(30, glowColor), Color.FromArgb(150, glowColor), LinearGradientMode.Vertical))
            {
                if (EllipticalGlow)
                {
                    graphics.SetClip(rect);
                    using (AntiAlias xaa = new AntiAlias(graphics))
                    {
                        using (GraphicsPath EllipseGlow = new GraphicsPath())
                        {
                            EllipseGlow.AddEllipse(rect.Left - 5, rect.Top - rect.Height / 2, rect.Width + 10, rect.Height);
                            graphics.FillPath(glow, EllipseGlow);
                        }
                    }
                    graphics.ResetClip();
                }
                else
                {
                    rcGlow.Height = 5;
                    graphics.FillRectangle(glow, rcGlow);
                }
            }
        }
    }
}
