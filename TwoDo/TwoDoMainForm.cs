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
using TwoDoLore;
using TwoDoMap;
using TwoDoQuest;
using TwoDoSkill;

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

        public TwoDoMainForm()
        {
            InitializeComponent();
            controller = new ControlsController(this);            
        }
    }
}
