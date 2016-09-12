using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDoCustomForm
{
    public class CustomBorder
    {
        public Color BorderColor { get; set;} 
        public CustomBorder()
        {
            BorderColor = Color.FromArgb(52, 52, 52);
        }

        public void Render(Rectangle border, Graphics graphics)
        {
            GraphicsPath BorderPath = new GraphicsPath();
            using (AntiAlias a = new AntiAlias(graphics))
            {
                DrawBorderLine(graphics, BorderPath, border, 0);
            }                            
        }

        private void DrawBorderLine(Graphics graphics, GraphicsPath path, Rectangle border, int corner)
        {
            int _corner = corner;
            path = CustomUtils.RoundRect((RectangleF)border, _corner, _corner, _corner, _corner);

            using (Pen _border = new Pen(BorderColor))
            {
                graphics.DrawPath(_border, path);
            }
            
        }
    }
}