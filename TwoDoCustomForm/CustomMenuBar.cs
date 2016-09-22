using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace TwoDoCustomForm
{
    public class CustomMenuBar : CustomBar
    {
        //color components
        private List<Color> MenuButtonsColorMix { get; set; }

        //Control Components
        private List<CustomMenuBarButton> menuButtons = new List<CustomMenuBarButton>();

        public Color ButtonBoxInnerBorder { get; set; }
        public Color ButtonBoxOuterBorder { get; set; }
        
        public CustomMenuBar()
        {
            MenuButtonsColorMix = new List<Color>();
            setDefaultCustomColors();              
        }

        private void setDefaultCustomColors()
        {
            // Default buttons mix colors:            
            MenuButtonsColorMix.Add(Color.FromArgb(112, 106, 108));
            MenuButtonsColorMix.Add(Color.FromArgb(56, 52, 53));
            MenuButtonsColorMix.Add(Color.FromArgb(53, 49, 50));
            MenuButtonsColorMix.Add(Color.FromArgb(71, 71, 71));
            MenuButtonsColorMix.Add(Color.FromArgb(112, 106, 108));

            // Default buttonBox border colors:
            ButtonBoxInnerBorder = Color.FromArgb(29, 8, 5);
            ButtonBoxOuterBorder = Color.FromArgb(60, 65, 68);
        }

        public List<CustomMenuBarButton> MenuButtons
        {
            get { return menuButtons; } 
        }

        public void RenderMenuBarButtonsBox(Rectangle rcBox, Graphics graphics, int singlePosX, int singlePosY)
        {
            using (AntiAlias aa = new AntiAlias(graphics))
            {
                int btnWidth = 0;
                int btnHeight = 0;
                foreach (CustomMenuBarButton btn in MenuButtons)
                {
                    btnWidth = btn.Width;
                    btnHeight = btn.Height;    
                }
                int _x = rcBox.Right - btnWidth;
                int _y = rcBox.Bottom - btnHeight;

                using (GraphicsPath buttonBox = BuildMenuButtonsBox(rcBox))
                {
                    using (LinearGradientBrush lgb = new LinearGradientBrush(rcBox, MenuButtonsColorMix[0], MenuButtonsColorMix[4], LinearGradientMode.Vertical))
                    {
                        lgb.InterpolationColors = CustomUtils.ColorMix(MenuButtonsColorMix, false);
                        graphics.FillPath(lgb, buttonBox);
                    }

                    // Draw separators
                    graphics.DrawLine(new Pen(ButtonBoxOuterBorder), rcBox.Right - btnWidth, rcBox.Bottom, rcBox.Right - btnWidth, rcBox.Top + 1);
                    graphics.DrawLine(new Pen(ButtonBoxInnerBorder), rcBox.Right - btnWidth - 1, rcBox.Bottom, rcBox.Right - btnWidth - 1, rcBox.Top + 1);
                    graphics.DrawLine(new Pen(ButtonBoxOuterBorder), rcBox.Right - btnWidth * 2, rcBox.Bottom - 2, rcBox.Right - btnWidth * 2, rcBox.Top + 1);
                    graphics.DrawLine(new Pen(ButtonBoxInnerBorder), rcBox.Right - btnWidth * 2 - 1, rcBox.Bottom - 2, rcBox.Right - btnWidth * 2 - 1, rcBox.Top + 1);

                    // Render buttons
                    graphics.SetClip(buttonBox);
                    foreach (CustomMenuBarButton btn in MenuButtons)
                    {
                        btn.LeftOffset = _x;
                        btn.TopOffset = _y;
                        btn.RenderMenuBarButton(btn.LeftOffset, btn.TopOffset, graphics);
                        _x -= btn.Width + 1;
                    }
                    graphics.ResetClip();
                    graphics.DrawPath(new Pen(ButtonBoxOuterBorder), buttonBox);
                    DrawInnerMenuBarBoxBorder(graphics, rcBox, ButtonBoxInnerBorder);
                }
            }
        }

        public GraphicsPath BuildMenuButtonsBox(Rectangle rec)
        {
            GraphicsPath buttonBox = new GraphicsPath();
            buttonBox.AddLine(rec.Left, rec.Top, rec.Left, rec.Bottom);
            buttonBox.AddLine(rec.Left, rec.Top, rec.Right - rec.Height, rec.Top);
            buttonBox.AddLine(rec.Right, rec.Top, rec.Right, rec.Bottom);
            buttonBox.AddLine(rec.Right - rec.Height, rec.Bottom, rec.Left, rec.Bottom);
            return buttonBox;
        }

        private void DrawInnerMenuBarBoxBorder(Graphics graphics, Rectangle rcBox, Color innerBorder)
        {
            rcBox.Inflate(-1, -1);
            using (GraphicsPath barBox = BuildMenuButtonsBox(rcBox))
            {
                using (Pen pInner = new Pen(innerBorder))
                {
                    graphics.DrawPath(pInner, barBox);
                }
            }
        }

        public void RenderMenuBar(Graphics graphics, Rectangle rec)
        {
            base.RenderBar(graphics, rec);
        }        
    }
}
