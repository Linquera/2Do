using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwoDoInterfaces;
using TwoDoLanguages;

namespace TwoDoItem
{
    public partial class NewItemForm : TwoDoCustomForm.CustomForm
    {
        public Item item;
        public event EventHandler Save;
        private OnCloseAction Action;
        private int editedIndex = 0;
        private bool advancedOpen { get; set; }
        private Size defaultSize = new Size(495, 225);
        private Size AdvancedSize = new Size(495, 450);
        private ToolTip tips = new ToolTip();

        public NewItemForm() : base(true, true)
        {
            this.MaximumSize = defaultSize;
            advancedOpen = false;
            menuTitle = Language.Instance.NewItem;
            InitializeComponent();
            setButtonEvents();
            picItem.SizeMode = PictureBoxSizeMode.StretchImage;
            Action = OnCloseAction.Add;
            
            this.CenterToParent();
            this.ShowInTaskbar = false;
            setLanguage();
            FillComboBox();
        }

        public NewItemForm(Item item, int index) : this()
        {
            this.item = item;
            LoadFormInfo();
            Action = OnCloseAction.Edit;
            editedIndex = index;

            btnAdd.Text = Language.Instance.Save;
        }

        private void setLanguage()
        {
            lblCategory.Text = Language.Instance.Category;
            gbObtain.Text = Language.Instance.HowToObtain;

            chkCraft.Text = Language.Instance.Craft;
            chkEvent.Text = Language.Instance.Event;
            chkLootOnGround.Text = Language.Instance.LootOnGround;
            chkMonsterDrop.Text = Language.Instance.MonsterDrop;
            chkNotObtainable.Text = Language.Instance.NotObtainable;
            chkQuest.Text = Language.Instance.Quest;
            chkStory.Text = Language.Instance.Story;
            chkTreasureBox.Text = Language.Instance.TreasureBox;

            lblName.Text = Language.Instance.Name;
            btnAdd.Text = Language.Instance.Add;
            btnAdvanced.Text = Language.Instance.Advanced;
            btnSelectImg.Text = Language.Instance.SelectImage;
        }

        private void FillComboBox()
        {
            var categories = Enum.GetValues(typeof(ItemCategoryType)).Cast<ItemCategoryType>();
            foreach (var category in categories)
            {
                cbCategory.Items.Add(category.GetDescription());
            }
            cbCategory.SelectedIndex = (int)ItemCategoryType.Loot;
        }

        private void setButtonEvents()
        {
            btnAdvanced.Click += Advanced_click;
            setButtonsConfig(btnAdvanced);

            btnAdd.Click += Add_click;
            setButtonsConfig(btnAdd);

            btnSelectImg.Click += SelectImg_click;
            setButtonsConfig(btnSelectImg);
        }

        private void Add_click(object sender, EventArgs e)
        {
            UpdateItem();
            onSave();
        }

        private void Advanced_click(object sender, EventArgs e)
        {
            if (advancedOpen)
            {
                this.MaximumSize = defaultSize;
                advancedOpen = false;
            }
            else
            {
                this.MaximumSize = AdvancedSize;
                this.Size = AdvancedSize;
                advancedOpen = true;
            }
        }       

        private void UpdateItem()
        {
            if (item == null) item = new Item();
            item.Name = txtName.Text;
            item.Figure = picItem.Image;
            item.Category = (ItemCategoryType)cbCategory.SelectedIndex;
            //Obtain
            item.Obtain.MonsterDrop = chkMonsterDrop.Checked;
            item.Obtain.NotObtainable = chkNotObtainable.Checked;
            item.Obtain.OnGround = chkLootOnGround.Checked;
            item.Obtain.Quest = chkQuest.Checked;
            item.Obtain.StoryLine = chkStory.Checked;
            item.Obtain.TreasureBox = chkTreasureBox.Checked;
            item.Obtain.Craft = chkCraft.Checked;
            item.Obtain.Event = chkEvent.Checked;
        }

        private void LoadFormInfo()
        {
            txtName.Text = item.Name;
            picItem.Image = item.Figure;
            cbCategory.SelectedIndex = (int)item.Category;

            chkCraft.Checked = item.Obtain.Craft;
            chkEvent.Checked = item.Obtain.Event;
            chkLootOnGround.Checked = item.Obtain.OnGround;
            chkMonsterDrop.Checked = item.Obtain.MonsterDrop;
            chkNotObtainable.Checked = item.Obtain.NotObtainable;
            chkQuest.Checked = item.Obtain.Quest;
            chkStory.Checked = item.Obtain.StoryLine;
            chkTreasureBox.Checked = item.Obtain.TreasureBox;
        }

        private void SelectImg_click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = Language.Instance.SelectImage;
                dlg.Filter = "Image Files (.jpeg, .png, .jpg, .gif)|*.jpeg;*.png;*.jpg;*.gif";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    picItem.Image = new Bitmap(dlg.FileName);
                }
            }
        }

        public virtual void onSave()
        {
            var handler = Save;
            if (handler != null)
            {
                handler(this, new NewItemEvents(Action) { editedIndex = editedIndex });
            }
            this.Close();
        }

        public override void onExitclick()
        {
            this.Close();
        }
    }

    public class NewItemEvents : EventArgs, IFloatFormEventArgs
    {
        public OnCloseAction Action { get; set; }
        public int editedIndex { get; set; }
        public NewItemEvents(OnCloseAction action)
        {
            Action = action;
        }
    }    
}
