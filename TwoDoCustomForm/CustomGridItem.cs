using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwoDoInterfaces;
using TwoDoUtils;

namespace TwoDoCustomForm
{
    public abstract class CustomGridItem : Panel, ICustomGridItem
    {
        private bool inControl = false;
        public bool Selected { get; set; }
        private Panel ComponentHolder;
        private Point PanelLocation = new Point(1, 1);

        public abstract int GetItemIndex();
        public abstract void ReloadDisplay();
        public abstract void LoadFromXml(string xml);
        public abstract string ToXml();
        public abstract CustomXml asXml();

        public CustomGridItem() : base()       
        {
            Selected = false;
            ComponentHolder = new Panel();
            ComponentHolder.BackColor = Color.FromArgb(65, 65, 65);                       
            Controls.Add(ComponentHolder);

            BackColor = Color.Black; 
            BorderStyle = BorderStyle.None;
        }

        private void event_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.Parent != null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    (this.Parent.Parent as ICustomGridHolder).EditableIndex(GetItemIndex());
                    (this.Parent as ICustomGrid).OpenFloatingMenu(new Point(Location.X + e.X, Location.Y + e.Y));
                }
                else if (e.Button == MouseButtons.Left && ModifierKeys.HasFlag(Keys.Control))
                {
                    if (this.Selected)
                    {
                        (this.Parent as ICustomGrid).SelectedItems.Remove(this);
                        UnMarkSelected(this);
                    }
                    else
                    {
                        (this.Parent as ICustomGrid).SelectedItems.Add(this);
                        MarkAsSelected();
                    }
                }
                else if (e.Button == MouseButtons.Left)
                {
                    if ((this.Parent as ICustomGrid).SelectedItems.Count == 1)
                    {
                        if (this.Selected)
                        {
                            UnMarkSelected(this);
                            return;
                        }
                    }

                    UnMarkSelected((this.Parent as ICustomGrid).SelectedItems);
                    (this.Parent as ICustomGrid).SelectedItems.Clear();
                    (this.Parent as ICustomGrid).SelectedItems.Add(this);
                    MarkAsSelected();
                }
            }
        }

        private void UnMarkSelected(List<ICustomGridItem> itens)
        {
            foreach (var item in itens)
            {
                if (item.Selected)
                {
                    UnMarkSelected(item);
                }
            }
        } 

        private void UnMarkSelected(ICustomGridItem item)
        {
            item.Selected = false;
            (item as CustomGridItem).ComponentHolder.BorderStyle = BorderStyle.None;
        }

        private void MarkAsSelected()
        {
            ComponentHolder.BorderStyle = BorderStyle.Fixed3D;
            Selected = true;
        }

        public bool inControls()
        {
            return inControl;
        }

        public void SetToControls()
        {
            inControl = true;
        }

        public void RemoveFromControls()
        {
            inControl = false;
        }

        public void SetSize(Size size)
        {
            this.Size = size;
            ComponentHolder.Size = new Size(size.Width - 2, size.Height - 2);
        }

        public void SetLocation(Point point)
        {
            this.Location = point;
            ComponentHolder.Location = PanelLocation;
        }

        public void AddComponent(Control component)
        {
            component.MouseDown += event_MouseDown;
            ComponentHolder.Controls.Add(component);
        }    
    }
}
