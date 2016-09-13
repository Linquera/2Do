using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace TwoDoCustomForm
{
    public class CustomMenuBarButton
    {
        public enum MenuBarButtonType { Minimize, Maximize, Close }
        public MenuBarButtonType ButtonType { get; set; }

        //Button Colors
        private Color ButtonColorStart { get; set; }
        private Color ButtonColorEnd { get; set; }

        public Color ButtonSymbolColor { get; set; }
        public Color ButtonHoverCollor { get; set; }
        public int Width { get; set; } 
        public int Height { get; set; }
        public int TopOffset { get; set; }
        public int LeftOffset { get; set; }
        public bool Hovering { get; set; } //mouse over

        public CustomMenuBarButton(MenuBarButtonType type) : this()
        {
            ButtonType = type;            
        }

        public CustomMenuBarButton(MenuBarButtonType type, Color clrStart, Color clrEnd) : this(type)
        {
            //for future configuration of highligth color
            ButtonColorStart = clrStart;
            ButtonColorEnd = clrEnd;
        }

        public CustomMenuBarButton()
        {
            ButtonType = MenuBarButtonType.Minimize;
            ButtonColorStart = Color.FromArgb(69, 121, 0);
            ButtonColorEnd = Color.FromArgb(214, 250, 23);
            ButtonSymbolColor = Color.FromArgb(152, 155, 162);
            ButtonHoverCollor = Color.FromArgb(242,231,51);
            Width = 26;
            Height = 26;
            TopOffset = 0;
            LeftOffset = 0;
        }

        public void RenderMenuBarButton(int x, int y, Graphics graphics, GraphicsPath buttonBox)
        {
            Pen pen = new Pen(ButtonSymbolColor);
            Rectangle rcBtn = new Rectangle(x, y, Width, Height);
            //works, but I didn't like much
            //if (Hovering)
            //{
                //to highligth the hovered button
                //FillButton(rcBtn, graphics, ButtonColorStart, ButtonColorEnd, buttonBox);
            //}
            
            if (Hovering)
                pen = new Pen(ButtonHoverCollor);
            else
                pen = new Pen(ButtonSymbolColor);

            graphics.SmoothingMode = SmoothingMode.None;
            switch (ButtonType)
            {
                case MenuBarButtonType.Minimize:
                    Rectangle rcMin = new Rectangle((rcBtn.Right - rcBtn.Width / 2) - 5, (rcBtn.Bottom - rcBtn.Height / 2) - 4, 8, 6);
                    rcMin.X -= 3;
                    rcMin.Y += 1;
                    
                    pen.Width = 2;
                    graphics.DrawLine(pen, rcMin.Right, rcMin.Top, rcMin.Right, rcMin.Top + 4);
                    graphics.DrawLine(pen, rcMin.Right - 1, rcMin.Top + 4, rcMin.Right + 4, rcMin.Top + 4);
                    graphics.FillRectangle(pen.Brush, rcMin.Right + 2, rcMin.Top, 2, 2);
                    graphics.FillRectangle(pen.Brush, rcMin.Right + 3, rcMin.Top - 1, 2, 2);
                    break;

                case MenuBarButtonType.Close:
                    Rectangle rcClose = new Rectangle((rcBtn.Right - rcBtn.Width / 2) - 6, (rcBtn.Bottom - rcBtn.Height / 2) - 3, 8, 6);
                    graphics.DrawLine(pen, (rcClose.Right - rcClose.Width / 2), (rcClose.Bottom - rcClose.Height / 2) - 2, (rcClose.Right - rcClose.Width / 2) + 1, (rcClose.Bottom - rcClose.Height / 2) - 2);
                    graphics.DrawLine(pen, (rcClose.Right - rcClose.Width / 2) + 1, (rcClose.Bottom - rcClose.Height / 2) - 1, (rcClose.Right - rcClose.Width / 2) + 2, (rcClose.Bottom - rcClose.Height / 2) - 1);
                    graphics.FillRectangle(pen.Brush, new Rectangle((rcClose.Right - rcClose.Width / 2) - 2, (rcClose.Bottom - rcClose.Height / 2) - 4, 2, 2));
                    graphics.FillRectangle(pen.Brush, new Rectangle((rcClose.Right - rcClose.Width / 2) + 3, (rcClose.Bottom - rcClose.Height / 2), 2, 2));
                    graphics.FillRectangle(pen.Brush, new Rectangle((rcClose.Right - rcClose.Width / 2) + 3, (rcClose.Bottom - rcClose.Height / 2) - 4, 2, 2));
                    graphics.FillRectangle(pen.Brush, new Rectangle((rcClose.Right - rcClose.Width / 2) - 2, (rcClose.Bottom - rcClose.Height / 2), 2, 2));
                    break;

                case MenuBarButtonType.Maximize:
                    Rectangle rcMax = new Rectangle((rcBtn.Right - rcBtn.Width / 2) - 4, (rcBtn.Bottom - rcBtn.Height / 2) - 4, 8, 6);
                    graphics.DrawLine(pen, rcMax.Right, rcMax.Top, rcMax.Right - 3, rcMax.Top);
                    pen.Width = 2;
                    graphics.DrawLine(pen, rcMax.Right, rcMax.Top + 1, rcMax.Right, rcMax.Top + 2);
                    graphics.DrawLine(pen, rcMax.Right, rcMax.Top + 3, rcMax.Right, rcMax.Bottom);
                    pen.Width = 1;
                    graphics.DrawLine(pen, rcMax.Right - 2, rcMax.Bottom - 1, rcMax.Right - 3, rcMax.Bottom - 1);
                    graphics.DrawLine(pen, rcMax.Right - 5, rcMax.Bottom - 1, rcMax.Left, rcMax.Bottom - 1);
                    pen.Width = 2;
                    graphics.DrawLine(pen, rcMax.Left, rcMax.Bottom, rcMax.Left, rcMax.Bottom - 3);
                    graphics.DrawLine(pen, rcMax.Left, rcMax.Bottom - 4, rcMax.Left, rcMax.Top);
                    graphics.DrawLine(pen, rcMax.Left, rcMax.Top + 1, rcMax.Left, rcMax.Top + 2);
                    pen.Width = 1;
                    graphics.DrawLine(pen, rcMax.Left + 1, rcMax.Top, rcMax.Left + 3, rcMax.Top);
                    break;
            }
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pen.Dispose();                    
        }

        private void FillButton(Rectangle btn, Graphics graphics, Color clrStart, Color clrEnd, GraphicsPath box)
        {
            btn.Height = 3;
            using (LinearGradientBrush lgb = new LinearGradientBrush(btn, clrStart, clrEnd, LinearGradientMode.Vertical))
            {
                graphics.FillRectangle(lgb, btn);
            }
        }
    }
}
