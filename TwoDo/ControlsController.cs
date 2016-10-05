using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using TwoDoCharacter;
using TwoDoInterfaces;
using TwoDoItem;
using TwoDoLore;
using TwoDoMap;
using TwoDoQuest;
using TwoDoSkill;
using TwoDoUtils;

namespace TwoDo
{
    public class ControlsController
    {
        private TwoDoMainForm mainForm;
        private XmlNode CharacterNode;
        private XmlNode MapNode;
        private XmlNode SkillNode;
        private XmlNode ItemNode;
        private XmlNode QuestNode;
        private XmlNode LoreNode;

        public ControlsController(TwoDoMainForm form)
        {
            mainForm = form;
            AddMenus();
            AddToolButtons();
            AddSideButtons();
            mainForm.ShowButtons();
        }

        internal void AddMenus()
        {
            mainForm.MainMenu.Items.Add(AddFileMenu());
            mainForm.MainMenu.Items.Add(AddEditMenu());
            mainForm.MainMenu.Items.Add(AddMapMenu());
            mainForm.MainMenu.Items.Add(AddCharacterMenu());
            mainForm.MainMenu.Items.Add(AddSkillMenu());
            mainForm.MainMenu.Items.Add(AddItensMenu());
            mainForm.MainMenu.Items.Add(AddQuestMenu());
            mainForm.MainMenu.Items.Add(AddLoreMenu());
            mainForm.MainMenu.Items.Add(AddConfigMenu());
            mainForm.MainMenu.Items.Add(AddMiscMenu());
        }

        private ToolStripItem AddSkillMenu()
        {
            var Skill = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Skills");
            Skill.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("New Skill", TwoDo.Properties.Resources.sSkill), notImplemented_Click));
            Skill.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Edit Skill"), notImplemented_Click));
            Skill.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Add Lore", TwoDo.Properties.Resources.sLore), notImplemented_Click));
            Skill.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("View Skill List", TwoDo.Properties.Resources.sSkillList), notImplemented_Click));
            Skill.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Search", TwoDo.Properties.Resources.sSearch), notImplemented_Click));
            return Skill;
        }

        private ToolStripItem AddItensMenu()
        {
            var Items = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Itens");
            Items.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("New Item", TwoDo.Properties.Resources.sItem), notImplemented_Click));
            Items.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Edit Item"), notImplemented_Click));
            Items.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Add Lore", TwoDo.Properties.Resources.sLore), notImplemented_Click));
            Items.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("View Item List", TwoDo.Properties.Resources.sSkillList), notImplemented_Click));
            Items.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Search", TwoDo.Properties.Resources.sSearch), notImplemented_Click));
            return Items;
        }

        private ToolStripItem AddQuestMenu()
        {
            var Quest = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Quest");
            Quest.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("New Quest", TwoDo.Properties.Resources.sQuest), notImplemented_Click));
            Quest.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Edit Quest"), notImplemented_Click));
            Quest.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Add Lore", TwoDo.Properties.Resources.sLore), notImplemented_Click));
            Quest.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Check Completation", TwoDo.Properties.Resources.sCompletation), notImplemented_Click));
            return Quest;
        }

        private ToolStripItem AddLoreMenu()
        {
            var Lore = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Lore");
            Lore.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("New Lore", TwoDo.Properties.Resources.sLore), notImplemented_Click));
            Lore.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("StoryLine", TwoDo.Properties.Resources.sStoryline), notImplemented_Click));
            Lore.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("New Linkword"), notImplemented_Click));
            return Lore;
        }

        private ToolStripItem AddConfigMenu()
        {
            var Config = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Config");
            Config.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Editor", TwoDo.Properties.Resources.sEditor), notImplemented_Click));
            Config.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Preferences", TwoDo.Properties.Resources.sConfig), notImplemented_Click));
            Config.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Password", TwoDo.Properties.Resources.sPassword), notImplemented_Click));
            return Config;
        }

        private ToolStripItem AddMiscMenu()
        {
            var Misc = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Misc.");
            Misc.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Custom Attributes"), notImplemented_Click));
            Misc.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Custom Elements"), notImplemented_Click));
            Misc.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Custom Characters Type"), notImplemented_Click));
            Misc.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Scripts"), notImplemented_Click));
            return Misc;
        }

        private ToolStripItem AddCharacterMenu()
        {
            var Character = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Character");
            Character.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("New Character", TwoDo.Properties.Resources.sCharacter), notImplemented_Click));
            Character.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Set Attributes", TwoDo.Properties.Resources.sAtributes), notImplemented_Click));
            Character.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Set Sprites", TwoDo.Properties.Resources.sSprite), notImplemented_Click));
            Character.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Set Animation", TwoDo.Properties.Resources.sAnimation), notImplemented_Click));
            Character.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Add Lore", TwoDo.Properties.Resources.sLore), notImplemented_Click));
            Character.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Add Skill", TwoDo.Properties.Resources.sSkill), notImplemented_Click));
            return Character;
        }

        private ToolStripItem AddMapMenu()
        {
            var Map = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Map");
            Map.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("New Map", TwoDo.Properties.Resources.sMap), notImplemented_Click));
            Map.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Add Link", TwoDo.Properties.Resources.sMaplink), notImplemented_Click));
            Map.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Add Characters", TwoDo.Properties.Resources.sCharacter), notImplemented_Click));
            Map.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Add Itens", TwoDo.Properties.Resources.sItem), notImplemented_Click));
            Map.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Add Quest", TwoDo.Properties.Resources.sQuest), notImplemented_Click));
            Map.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Spawn Point", TwoDo.Properties.Resources.sSpawnPoint), notImplemented_Click));
            return Map;
        }

        private ToolStripItem AddEditMenu()
        {
            var Edit = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Edit");
            Edit.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Undo", TwoDo.Properties.Resources.sUndo), notImplemented_Click));
            Edit.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Redo", TwoDo.Properties.Resources.sRedo), notImplemented_Click));
            Edit.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Duplicate", TwoDo.Properties.Resources.sDuplicate), notImplemented_Click));
            Edit.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Delete", TwoDo.Properties.Resources.sDelete), notImplemented_Click));
            Edit.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Select All", TwoDo.Properties.Resources.sSelectAll), notImplemented_Click));
            Edit.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Sort"), notImplemented_Click));
            return Edit;
        }

        private TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem VinculaEvento(TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem menu, EventHandler clickEvent)
        {
            menu.Click += clickEvent;
            return menu;
        }

        public TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem AddFileMenu()
        {
            var File = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("File");
            File.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("New Project", TwoDo.Properties.Resources.sNewFile), notImplemented_Click));
            File.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Open Project", TwoDo.Properties.Resources.sOpen), notImplemented_Click));
            File.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Rename Project"), notImplemented_Click));
            File.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Save", TwoDo.Properties.Resources.sSave), notImplemented_Click));
            File.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Save All"), notImplemented_Click));
            File.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Import", TwoDo.Properties.Resources.sImport), notImplemented_Click));
            File.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Export", TwoDo.Properties.Resources.sExport), notImplemented_Click));
            File.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Exit", TwoDo.Properties.Resources.sExit), exit_Click));
            return File;
        }

        private static void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private static void notImplemented_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented");
        }

        internal void AddToolButtons()
        {
            mainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.mNewFile, notImplemented_Click));
            mainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.mOpen, Load_Click));
            mainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.mSave, save_Click));
            mainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.mSave, notImplemented_Click)); //save all -- find an icon
            mainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.mUndo, notImplemented_Click));
            mainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.mRedo, notImplemented_Click));
            mainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.mSelectAll, notImplemented_Click));
            mainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.mCharacter, notImplemented_Click));
            mainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.mMap, notImplemented_Click));
            mainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.mMaplink, notImplemented_Click));
            mainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.mSkill, notImplemented_Click));
            mainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.mSkillList, notImplemented_Click));
            mainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.mItem, notImplemented_Click));
            mainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.mLore, notImplemented_Click));
            mainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.mQuest, notImplemented_Click));
            mainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.mCompletation, notImplemented_Click));
        }

        private void Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.InitialDirectory = "c:\\"; //save last open position
            op.Filter = "2Do files (*.2Do)|*.2Do";            ;
            op.RestoreDirectory = true;
            if(op.ShowDialog() == DialogResult.OK)
            {                
                string file = op.FileName;
                try
                {
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(System.IO.File.ReadAllText(file));
                    var node = xml.DocumentElement.SelectSingleNode("//TwoDo");
                    CharacterNode = node.SelectSingleNode("CharacterForm");
                    MapNode = node.SelectSingleNode("MapForm");
                    SkillNode = node.SelectSingleNode("SkillForm");
                    ItemNode = node.SelectSingleNode("ItemForm");
                    QuestNode = node.SelectSingleNode("QuestForm");
                    LoreNode = node.SelectSingleNode("LoreForm");                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file: " + ex.Message);
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            xml.AddRootElement("TwoDo");
            xml.AddXmlNode("TwoDo", mainForm.CharForm.ToXml());

            System.IO.File.WriteAllText(@"C:\save.2do", xml.OuterXml);
        }

        private Button setButton(string text, Image icon, EventHandler e)
        {
            var button = new Button();
            button.Image = icon;
            button.Text = text;
            button.Click += e;
            return button;
        }

        internal void AddSideButtons()
        {
            mainForm.SideBar.Buttons.Add(setButton("Character", TwoDo.Properties.Resources.bCharacter, CharacterForm_click));
            mainForm.SideBar.Buttons.Add(setButton("Map", TwoDo.Properties.Resources.bMap, MapForm_click));
            mainForm.SideBar.Buttons.Add(setButton("Skill", TwoDo.Properties.Resources.bSkill, SkillForm_click));
            mainForm.SideBar.Buttons.Add(setButton("Item", TwoDo.Properties.Resources.bItem, ItemForm_click));
            mainForm.SideBar.Buttons.Add(setButton("Quest", TwoDo.Properties.Resources.bQuest, QuestForm_click));
            mainForm.SideBar.Buttons.Add(setButton("Lore", TwoDo.Properties.Resources.bLore, LoreForm_click));   
        }

        private void CharacterForm_click(object sender, EventArgs e)
        {
            if (mainForm.CharForm == null)
            {
                mainForm.CharForm = new CharacterForm(true);
                if (CharacterNode != null) { mainForm.CharForm.LoadFromXml(CharacterNode.InnerXml); }                    
                OpenMdiForm(mainForm.CharForm);
            }
            else if (!mainForm.CharForm.Focused)
            {
                mainForm.CharForm.Focus();
            }
        }

        private void MapForm_click(object sender, EventArgs e)
        {
            if (mainForm.MapForm == null)
            {
                mainForm.MapForm = new MapForm(true);
                OpenMdiForm(mainForm.MapForm);
            }
            else if (!mainForm.MapForm.Focused)
            {
                mainForm.MapForm.Focus();
            }
        }

        private void SkillForm_click(object sender, EventArgs e)
        {
            if (mainForm.SkillForm == null)
            {
                mainForm.SkillForm = new SkillForm(true);
                OpenMdiForm(mainForm.SkillForm);
            }
            else if (!mainForm.SkillForm.Focused)
            {
                mainForm.SkillForm.Focus();
            }
        }

        private void ItemForm_click(object sender, EventArgs e)
        {
            if (mainForm.ItemForm == null)
            {
                mainForm.ItemForm = new ItemForm(true);
                OpenMdiForm(mainForm.ItemForm);
            }
            else if (!mainForm.ItemForm.Focused)
            {
                mainForm.ItemForm.Focus();
            }
        }

        private void QuestForm_click(object sender, EventArgs e)
        {
            if (mainForm.QuestForm == null)
            {
                mainForm.QuestForm = new QuestForm(true);
                OpenMdiForm(mainForm.QuestForm);
            }
            else if (!mainForm.QuestForm.Focused)
            {
                mainForm.QuestForm.Focus();
            }
        }

        private void LoreForm_click(object sender, EventArgs e)
        {
            if (mainForm.LoreForm == null)
            {
                mainForm.LoreForm = new LoreForm(true);
                OpenMdiForm(mainForm.LoreForm);
                
            }
            else if (!mainForm.LoreForm.Focused)
            {
                mainForm.LoreForm.Focus();
            }
        }

        private void OpenMdiForm(Form form)
        {
            form.MdiParent = mainForm;
            form.Dock = DockStyle.Fill;
            (form as ITwoDoMdiForm).MdiExitClick += CloseMdiForm;
            form.Show();
        }

        private void CloseMdiForm(object sender, EventArgs e)
        {
            switch ((e as IMdiEventArgs).FormType)
            {
                case MdiFormType.Character: mainForm.CharForm = null; break;
                case MdiFormType.Map: mainForm.MapForm = null; break;
                case MdiFormType.Skill: mainForm.SkillForm = null; break;
                case MdiFormType.Items: mainForm.ItemForm = null; break;
                case MdiFormType.Quest: mainForm.QuestForm = null; break;
                case MdiFormType.Lore: mainForm.LoreForm = null; break;
            }               
        }
    }
}
