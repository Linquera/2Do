using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoDo
{
    public static class ControlsController
    {
        internal static void AddMenus(TwoDoMainForm form)
        {   
            form.MainMenu.Items.Add(AddFileMenu());
            form.MainMenu.Items.Add(AddEditMenu());
            form.MainMenu.Items.Add(AddMapMenu());
            form.MainMenu.Items.Add(AddCharacterMenu());
            form.MainMenu.Items.Add(AddSkillMenu());
            form.MainMenu.Items.Add(AddItensMenu());
            form.MainMenu.Items.Add(AddQuestMenu());
            form.MainMenu.Items.Add(AddLoreMenu());
            form.MainMenu.Items.Add(AddConfigMenu());
            form.MainMenu.Items.Add(AddMiscMenu());
        }

        private static ToolStripItem AddSkillMenu()
        {
            var Skill = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Skills");
            Skill.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("New Skill", TwoDo.Properties.Resources.sSkill), newFile_Click));
            Skill.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Edit Skill"), newFile_Click));
            Skill.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Add Lore", TwoDo.Properties.Resources.sLore), newFile_Click));
            Skill.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("View Skill List", TwoDo.Properties.Resources.sSkillList), newFile_Click));
            Skill.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Search", TwoDo.Properties.Resources.sSearch), newFile_Click));
            return Skill;
        }

        private static ToolStripItem AddItensMenu()
        {
            var Items = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Itens");
            Items.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("New Item", TwoDo.Properties.Resources.sItem), newFile_Click));
            Items.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Edit Item"), newFile_Click));
            Items.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Add Lore", TwoDo.Properties.Resources.sLore), newFile_Click));
            Items.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("View Item List", TwoDo.Properties.Resources.sSkillList), newFile_Click));
            Items.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Search", TwoDo.Properties.Resources.sSearch), newFile_Click));
            return Items;
        }

        private static ToolStripItem AddQuestMenu()
        {
            var Quest = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Quest");
            Quest.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("New Quest", TwoDo.Properties.Resources.sQuest), newFile_Click));
            Quest.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Edit Quest"), newFile_Click));
            Quest.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Add Lore", TwoDo.Properties.Resources.sLore), newFile_Click));
            Quest.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Check Completation", TwoDo.Properties.Resources.sCompletation), newFile_Click));
            return Quest;
        }

        private static ToolStripItem AddLoreMenu()
        {
            var Lore = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Lore");
            Lore.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("New Lore", TwoDo.Properties.Resources.sLore), newFile_Click));
            Lore.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("StoryLine", TwoDo.Properties.Resources.sStoryline), newFile_Click));
            Lore.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("New Linkword"), newFile_Click));
            return Lore;
        }

        private static ToolStripItem AddConfigMenu()
        {
            var Config = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Config");
            Config.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Editor", TwoDo.Properties.Resources.sEditor), newFile_Click));
            Config.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Preferences", TwoDo.Properties.Resources.sConfig), newFile_Click));
            Config.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Password", TwoDo.Properties.Resources.sPassword), newFile_Click));
            return Config;
        }

        private static ToolStripItem AddMiscMenu()
        {
            var Misc = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Misc.");
            Misc.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Custom Attributes"), newFile_Click));
            Misc.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Custom Elements"), newFile_Click));
            Misc.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Custom Characters Type"), newFile_Click));
            Misc.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Scripts"), newFile_Click));
            return Misc;
        }

        private static ToolStripItem AddCharacterMenu()
        {
            var Character = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Character");
            Character.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("New Character", TwoDo.Properties.Resources.sCharacter), newFile_Click));
            Character.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Set Attributes", TwoDo.Properties.Resources.sAtributes), newFile_Click));
            Character.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Set Sprites", TwoDo.Properties.Resources.sSprite), newFile_Click));
            Character.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Set Animation", TwoDo.Properties.Resources.sAnimation), newFile_Click));
            Character.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Add Lore", TwoDo.Properties.Resources.sLore), newFile_Click));
            Character.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Add Skill", TwoDo.Properties.Resources.sSkill), newFile_Click));
            return Character;
        }

        private static ToolStripItem AddMapMenu()
        {
            var Map = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Map");
            Map.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("New Map", TwoDo.Properties.Resources.sMap), newFile_Click));
            Map.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Add Link", TwoDo.Properties.Resources.sMaplink), newFile_Click));
            Map.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Add Characters", TwoDo.Properties.Resources.sCharacter), newFile_Click));
            Map.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Add Itens", TwoDo.Properties.Resources.sItem), newFile_Click));
            Map.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Add Quest", TwoDo.Properties.Resources.sQuest), newFile_Click));
            Map.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Spawn Point", TwoDo.Properties.Resources.sSpawnPoint), newFile_Click));
            return Map;
        }

        private static ToolStripItem AddEditMenu()
        {
            var Edit = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Edit");
            Edit.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Undo", TwoDo.Properties.Resources.sUndo), newFile_Click));
            Edit.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Redo", TwoDo.Properties.Resources.sRedo), newFile_Click));
            Edit.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Duplicate", TwoDo.Properties.Resources.sDuplicate), newFile_Click));
            Edit.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Delete", TwoDo.Properties.Resources.sDelete), newFile_Click));
            Edit.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Select All", TwoDo.Properties.Resources.sSelectAll), newFile_Click));
            Edit.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Sort"), newFile_Click));
            return Edit;
        }

        private static TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem VinculaEvento(TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem menu, EventHandler clickEvent)
        {
            menu.Click += clickEvent;
            return menu;
        }

        public static TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem AddFileMenu()
        {
            var File = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("File");
            File.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("New Project", TwoDo.Properties.Resources.sNewFile), newFile_Click));
            File.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Open Project", TwoDo.Properties.Resources.sOpen), newFile_Click));
            File.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Rename Project"), newFile_Click));
            File.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Save", TwoDo.Properties.Resources.sSave), newFile_Click));
            File.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Save All"), newFile_Click));
            File.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Import", TwoDo.Properties.Resources.sImport), newFile_Click));
            File.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Export", TwoDo.Properties.Resources.sExport), newFile_Click));
            File.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Exit", TwoDo.Properties.Resources.sExit), exit_Click));
            return File;
        }

        private static void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private static void newFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented");
        }

        internal static void AddToolButtons(TwoDoMainForm twoDoMainForm)
        {
            twoDoMainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.mNewFile));
            twoDoMainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.mOpen));
            twoDoMainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.mSave));
            twoDoMainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.mSave)); //save all -- find an icon
            twoDoMainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.mUndo));
            twoDoMainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.mRedo));
            twoDoMainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.mSelectAll));
            twoDoMainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.mCharacter));
            twoDoMainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.mMap));
            twoDoMainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.mMaplink));
            twoDoMainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.mSkill));
            twoDoMainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.mSkillList));
            twoDoMainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.mItem));
            twoDoMainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.mLore));
            twoDoMainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.mQuest));
            twoDoMainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.mCompletation));
        }

        private static Button setButton(string text, Image icon)
        {
            var button = new Button();
            button.Image = icon;
            button.Text = text;
            return button;
        }

        internal static void AddSideButtons(TwoDoMainForm twoDoMainForm)
        {
            twoDoMainForm.SideBar.Buttons.Add(setButton("Character", TwoDo.Properties.Resources.bCharacter));
            twoDoMainForm.SideBar.Buttons.Add(setButton("Map", TwoDo.Properties.Resources.bMap));
            twoDoMainForm.SideBar.Buttons.Add(setButton("Skill", TwoDo.Properties.Resources.bSkill));
            twoDoMainForm.SideBar.Buttons.Add(setButton("Item", TwoDo.Properties.Resources.bItem));
            twoDoMainForm.SideBar.Buttons.Add(setButton("Quest", TwoDo.Properties.Resources.bQuest));
            twoDoMainForm.SideBar.Buttons.Add(setButton("Lore", TwoDo.Properties.Resources.bLore));   
        }
    }
}
