﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwoDoCustomForm;
using TwoDoInterfaces;
using TwoDoUtils;

namespace TwoDoItem
{
    public class ItemGridItem : CustomGridItem
    {
        public Item item { get; set; }
        private Label DisplayName = new Label();
        private PictureBox DisplayImage = new PictureBox(); 

        public ItemGridItem() : base()       
        {  }

        public ItemGridItem(Item item, int index) : this()
        {
            this.item = item;
            item.Index = index;
            setImageConfig();
            setLabelConfig();
        }

        private void setImageConfig()
        {
            DisplayImage.Size = new Size(160, 160);
            DisplayImage.Image = item.Figure;
            DisplayImage.SizeMode = PictureBoxSizeMode.StretchImage;
            DisplayImage.MouseDoubleClick += event_MouseDoubleClick;
            AddComponent(DisplayImage);
        }

        private void setLabelConfig()
        {
            DisplayName.Text = item.Name;
            DisplayName.ForeColor = Color.White;
            DisplayName.Dock = DockStyle.Bottom;
            DisplayName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            DisplayName.MouseDoubleClick += event_MouseDoubleClick;
            AddComponent(DisplayName);
        }

        private void event_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Parent != null)
            {
                (this.Parent.Parent as ICustomGridHolder).EditableIndex(item.Index);
                (this.Parent.Parent as ICustomGridHolder).EditItem(item.Index);
            }
        }

        public string getItemName()
        {
            if (item != null)
            {
                return item.Name;
            }
            return "";
        }

        public override int GetItemIndex()
        {
            return item.Index;
        }

        public override void LoadFromXml(string xml)
        {
            item = new Item();
            item.LoadFromXml(xml);
            setImageConfig();
            setLabelConfig();
        }

        public override void ReloadDisplay()
        {
            this.DisplayName.Text = this.item.Name;
            this.DisplayImage.Image = item.Figure;
        }        

        public override string ToXml()
        {
            return item.ToXml();
        }

        public override CustomXml asXml()
        {
            return item.asXml();
        }
    }
}
