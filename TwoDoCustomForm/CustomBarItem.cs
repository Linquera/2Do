using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;

namespace TwoDoCustomForm
{
    public class CustomBarItem
    {
        public int Width { get; set; } 
        public int Height { get; set; } 
        public string Text { get; set; }
        public Color InnerColor { get; set; }
        public Color OuterColor { get; set; }
        public Color FontColor { get; set; }
        public Font FontType { get; set; }

        public CustomBarItem()
        { 
            setDefaultValues();
        }

	    public CustomBarItem(int width) : this()
	    {
            Width = width;
	    }

        public CustomBarItem(int width, string text) : this(width)
	    {
		    Text = text;
	    }

        private void setDefaultValues()
        {
 	        Width = 90;
            Height = 22;
            Text = string.Empty;
            InnerColor = Color.FromArgb(27, 27, 27);
            OuterColor = Color.FromArgb(36, 36, 36);
            FontColor = Color.FromArgb(255, 255, 255);
            FontType = new Font("Visitor TT2 BRK", 9);
        }

        public void RenderBarItem(Graphics graphics, int left, int top)
        {
            Pen separator = new Pen(OuterColor);
            Rectangle rcItem = new Rectangle(left, top, Width, Height);
            // positioning text rec
            Rectangle rcText = rcItem;                       
            rcText.X += 2;
            rcText.Width -= 4;

            // draw separators:
            graphics.DrawLine(separator, rcItem.Left + rcItem.Width, rcItem.Top + 1, rcItem.Left + rcItem.Width, rcItem.Top + Height - 1);
            separator = new Pen(InnerColor);
            graphics.DrawLine(separator, rcItem.Left + rcItem.Width + 1, rcItem.Top + 1, rcItem.Left + rcItem.Width + 1, rcItem.Top + Height - 1);
            
            // draw item text:
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Near;
            sf.Trimming = StringTrimming.EllipsisCharacter;
            SolidBrush sb = new SolidBrush(FontColor);

            graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            graphics.DrawString(Text, FontType, sb, rcText, sf);

            separator.Dispose();
            sf.Dispose();
            sb.Dispose();            
        }
    }
}
