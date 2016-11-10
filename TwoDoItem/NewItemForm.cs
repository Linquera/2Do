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
            InitializeComponent();
        }

        public NewItemForm(Item item, int index) : this()
        {
            this.item = item;            
            LoadFormInfo();
            Action = OnCloseAction.Edit;
            editedIndex = index;
        }

        private void LoadFormInfo()
        {
            throw new NotImplementedException();
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
