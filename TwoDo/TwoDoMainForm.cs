using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwoDoCharacter;
using TwoDoItem;
using TwoDoLanguages;
using TwoDoLore;
using TwoDoMap;
using TwoDoQuest;
using TwoDoSkill;
using TwoDoInterfaces;

namespace TwoDo
{
    public partial class TwoDoMainForm : TwoDoCustomForm.CustomMainForm
    {        
        private ControlsController controller;
        public CharacterForm CharForm = null;
        public MapForm MapForm = null;
        public SkillForm SkillForm = null;
        public ItemForm ItemForm = null;
        public QuestForm QuestForm = null;
        public LoreForm LoreForm = null;
        public ProjectSave ProjectSave = null;

        public TwoDoMainForm()
        {
            InitializeComponent();
            controller = new ControlsController(this);
                        
            if (!this.isMaximized)
            {
                this.ToogleMaxMinSize();
            }
        }

        public override void onExitclick()
        {
           /* if (controller.PendingSave)
            {
                switch(MessageBox.Show("Unsaved information will be lost?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information))
                {
                    case DialogResult.Yes:
                        controller.Save();
                        break;
                    case DialogResult.No:
                        Application.Exit();
                    break;
                }
            }
            else*/
                Application.Exit();
        }
    }
}
