using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoDoCustomForm
{
    public class CustomMenuStrip : MenuStrip
    {
        public CustomMenuStrip()
        {
            this.Renderer = new CustomRenderer();            
        }

        public CustomMenuStrip(Rectangle container) : this()
        {
            this.Dock = DockStyle.None;
            this.SetBounds(container.X - 4, container.Y + 2, container.Width, container.Height);
        }

        private class CustomRenderer : ToolStripProfessionalRenderer
        {
            public CustomRenderer() : base(new CustomColors()) { }         
        }

        private class CustomColors : ProfessionalColorTable
        {
            public CustomColors() { base.UseSystemColors = false; }
            public override Color MenuItemSelected { get { return Color.FromArgb(95, 95, 95); } } //gray            
            public override Color MenuItemSelectedGradientBegin { get { return Color.FromArgb(100, 100, 100); } }
            public override Color MenuItemSelectedGradientEnd { get { return Color.FromArgb(100, 100, 100); } }
            public override Color MenuBorder{ get { return Color.Transparent; } }
            public override Color MenuItemBorder { get { return Color.FromArgb(10, 10, 10); } }
            public override Color ToolStripDropDownBackground { get { return Color.FromArgb(35, 35, 35); } }
                        
            //Pressed Menu
            public override Color MenuItemPressedGradientBegin { get { return Color.FromArgb(35, 35, 35); } }
            public override Color MenuItemPressedGradientEnd { get { return Color.FromArgb(35, 35, 35); } }
            public override Color MenuItemPressedGradientMiddle { get { return Color.FromArgb(35, 35, 35); } }

            // freaking left side line            
            public override Color ImageMarginGradientBegin { get { return Color.FromArgb(35, 35, 35); } }
            public override Color ImageMarginGradientEnd { get { return Color.FromArgb(35, 35, 35); } }
            public override Color ImageMarginGradientMiddle { get { return Color.FromArgb(35, 35, 35); } }

        }
        
        public class CustomMenuStripItem : ToolStripMenuItem
        {
            public CustomMenuStripItem(string description) : base(description)
            {                
                this.ForeColor = Color.White;
            }                        
        }
    }    
}
