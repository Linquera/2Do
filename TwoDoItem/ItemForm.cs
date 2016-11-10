using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using TwoDoCustomForm;
using TwoDoInterfaces;
using TwoDoUtils;
using TwoDoLanguages;

namespace TwoDoItem
{
    public partial class ItemForm : CustomForm, ITwoDoMdiForm, ITwoDoXml, ICustomGridHolder
    {
        public static string Root = "ItemForm";
        private NewItemForm newItemForm;
        private ToolStripMenuItem editMenuItem;
        private ToolStripMenuItem deleteMenuItem;
        private int currentIndexEdit = 0;
        private CustomXml Xml { get; set; }
        public event EventHandler MdiExitClick;
        public CustomGridPanel ItemGrid;

        public ItemForm(bool onlyCloseButton) : base(onlyCloseButton, false)
        {
            InitializeComponent();
            MainMenuBar.BarColor = Color.FromArgb(70, 70, 70);
            MainMenuBar.BarGradientColorStart = Color.FromArgb(70, 70, 70);
            MainMenuBar.BarGradientColorEnd = Color.FromArgb(70, 70, 70);
            Xml = new CustomXml(Root);
            menuTitle = Language.Instance.Character;
            ItemGrid = new CustomGridPanel(this.ClientRectangle);
            ItemGrid.Padding = new Padding(1, 1, 0, 30);
            setFloatMenuConfig();
            this.Controls.Add(ItemGrid);
        }

        private void setFloatMenuConfig()
        {
            ItemGrid.FloatingMenu.Items.Add(new ToolStripMenuItem(Language.Instance.NewCharacter, null, newItem_click));
            editMenuItem = new ToolStripMenuItem(Language.Instance.Edit, null, Edit_click);
            editMenuItem.Visible = false;
            ItemGrid.FloatingMenu.Items.Add(editMenuItem);
            deleteMenuItem = new ToolStripMenuItem(Language.Instance.Delete, null, Delete_click);
            deleteMenuItem.Visible = false;
            ItemGrid.FloatingMenu.Items.Add(deleteMenuItem);
            ItemGrid.FloatingMenu.Items.Add(new ToolStripMenuItem(Language.Instance.Sort, null, Sort_click));
            ItemGrid.FloatingMenu.Closed += FloatingMenu_Closing;
        }

        private void Delete_click(object sender, EventArgs e)
        {
            var delete = (ItemGrid.Items.Find(x => x.GetItemIndex() == currentIndexEdit));
            if (MessageBox.Show(string.Format("{0} \"{1}\" ?", Language.Instance.Delete, (delete as CustomImageGridItem).item.Name),
                "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                ItemGrid.RemoveItem(delete);
            }
        }

        private void FloatingMenu_Closing(object sender, ToolStripDropDownClosedEventArgs e)
        {
            editMenuItem.Visible = false;
            deleteMenuItem.Visible = false;
        }

        private void Edit_click(object sender, EventArgs e)
        {
            EditItem();
        }
        private void EditItem()
        {
            Item edit = ((ItemGrid.Items.Find(x => x.GetItemIndex() == currentIndexEdit) as CustomImageGridItem).item as Item);
            newItemForm = new NewItemForm(edit, currentIndexEdit);
            newItemForm.Save += newItemForm_Save;
            newItemForm.ShowDialog();
        }
        private void Sort_click(object sender, EventArgs e)
        {

        }

        private void newItem_click(object sender, EventArgs e)
        {
            newItemForm = new NewItemForm();
            newItemForm.Save += newItemForm_Save;
            newItemForm.ShowDialog();
        }

        private void newItemForm_Save(object sender, EventArgs e)
        {
            var item = (sender as NewItemForm).item;
            if ((e as NewItemEvents).Action == OnCloseAction.Edit)
            {
                var griditem = (ItemGrid.Items.Find(x => x.GetItemIndex() == (e as NewItemEvents).editedIndex) as CustomImageGridItem);
                griditem.ReloadDisplay();
            }
            else if ((e as NewItemEvents).Action == OnCloseAction.Add)
            {
                ItemGrid.Items.Add(new CustomImageGridItem(item, ItemGrid.Items.Count + 1));
            }
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            ItemGrid.DrawItens();
        }
        public override void onExitclick()
        {
            this.Close();
            onMdiExitClick();
            this.Dispose();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (ItemGrid != null) ItemGrid.FillParent(this.ClientRectangle);
        }

        public virtual void onMdiExitClick()
        {
            var handler = MdiExitClick;
            if (handler != null)
            {
                handler(this, new ItemEvents(getMdiFormType()));
            }
        }

        public MdiFormType getMdiFormType()
        {
            return MdiFormType.Items;
        }

        public void LoadFromXml(string xml)
        {
            Xml.LoadXml(xml);
            var items = Xml.DocumentElement.SelectNodes("Items/Item");
            foreach (XmlNode item in items)
            {
                var grid = new CustomImageGridItem();
                grid.LoadFromXml(new Item(), item.OuterXml);
                ItemGrid.Items.Add(grid);
            }
            ItemGrid.DrawItens();
        }

        public string ToXml()
        {
            return asXml().InnerXml;
        }

        public void EditableIndex(int index)
        {
            editMenuItem.Visible = true;
            deleteMenuItem.Visible = true;
            currentIndexEdit = index;
        }

        public void EditItem(int index)
        {
            currentIndexEdit = index;
            EditItem();
        }

        public CustomXml asXml()
        {
            CustomXml innerXml = new CustomXml("Items");
            foreach (var item in ItemGrid.Items)
            {
                innerXml.Node(item.asXml());
            }
            Xml.Node(innerXml, Root);
            return Xml;
        }
    }

    public class ItemEvents : EventArgs, IMdiEventArgs
    {
        public MdiFormType FormType { get; set; }
        public ItemEvents(MdiFormType formType)
        {
            FormType = formType;
        }
    }
}
