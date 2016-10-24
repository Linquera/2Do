using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwoDoInterfaces;

namespace TwoDoCustomForm
{
    public class CustomGridPanel : Panel, ICustomGrid
    {
        public Rectangle ParentRectangle;
        private List<ICustomGridItem> items = new List<ICustomGridItem>();
        public List<ICustomGridItem> Items { get { return items; } }
        public Size ItensSize = new Size(160,175);
        public ContextMenuStrip FloatingMenu { get; set; }

        public CustomGridPanel(Rectangle ClientRectangle)
        {
            this.ParentRectangle = ClientRectangle;
            this.AutoScroll = true;
            this.HorizontalScroll.Enabled = false;
            this.HorizontalScroll.Visible = false;
            this.BackColor = Color.FromArgb(70, 70, 70);
            FloatingMenu = new ContextMenuStrip();
            FillParent();           
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Right)
            {
                OpenFloatingMenu(e.Location);
            }
        }

        public void FillParent()
        {
            this.Size = new Size(ParentRectangle.Width - Padding.Right, ParentRectangle.Height - Padding.Bottom);
            this.Location = new Point(0 + Padding.Left, 26 + Padding.Top);
        }

        public void FillParent(Rectangle ClientRectangle)
        {
            ParentRectangle = ClientRectangle;
            FillParent();
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            DrawItens();
        }

        public void DrawItens()
        {            
            int itensPerLine = ClientRectangle.Width / ItensSize.Width;
            int currentRow = 0, currentColumn = 0;
            foreach (var item in Items)
            {
                item.SetSize(ItensSize);
                item.SetLocation(new Point((ItensSize.Width * currentColumn) + Padding.Left, (ItensSize.Height * currentRow) + Padding.Top));
                currentColumn++;
                if (currentColumn >= itensPerLine)
                {
                    currentRow++;
                    currentColumn = 0;
                }
                if (!item.inControls())
                {
                    this.Controls.Add((Panel)item);
                    item.SetToControls();
                }
            }
        }

        public void RemoveItem(ICustomGridItem item)
        {
            item.RemoveFromControls();
            this.Controls.Remove((Panel)item);
            Items.Remove(item);
            DrawItens();
        }

        public void OpenFloatingMenu(Point e)
        {
            FloatingMenu.Show(this, e);
        }
    }
}
