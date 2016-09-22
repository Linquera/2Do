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
            Skill.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("New Skill", TwoDo.Properties.Resources.addskill), newFile_Click));
            Skill.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Edit Skill"), newFile_Click));
            Skill.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Add Lore", TwoDo.Properties.Resources.addlore), newFile_Click));
            Skill.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("View Skill List", TwoDo.Properties.Resources.list), newFile_Click));
            Skill.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Search", TwoDo.Properties.Resources.search), newFile_Click));
            return Skill;
        }

        private static ToolStripItem AddItensMenu()
        {
            var Items = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Itens");
            Items.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("New Item", TwoDo.Properties.Resources.item), newFile_Click));
            Items.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Edit Item"), newFile_Click));
            Items.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Add Lore", TwoDo.Properties.Resources.addlore), newFile_Click));
            Items.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("View Item List", TwoDo.Properties.Resources.list), newFile_Click));
            Items.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Search", TwoDo.Properties.Resources.search), newFile_Click));
            return Items;
        }

        private static ToolStripItem AddQuestMenu()
        {
            var Quest = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Quest");
            Quest.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("New Quest", TwoDo.Properties.Resources.quest), newFile_Click));
            Quest.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Edit Quest"), newFile_Click));
            Quest.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Add Lore", TwoDo.Properties.Resources.addlore), newFile_Click));
            Quest.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Check Completation", TwoDo.Properties.Resources.completation), newFile_Click));
            return Quest;
        }

        private static ToolStripItem AddLoreMenu()
        {
            var Lore = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Lore");
            Lore.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("New Lore", TwoDo.Properties.Resources.addlore), newFile_Click));
            Lore.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("StoryLine", TwoDo.Properties.Resources.storyline), newFile_Click));
            Lore.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("New Linkword"), newFile_Click));
            return Lore;
        }

        private static ToolStripItem AddConfigMenu()
        {
            var Config = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Config");
            Config.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Editor", TwoDo.Properties.Resources.editor), newFile_Click));
            Config.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Preferences", TwoDo.Properties.Resources.config), newFile_Click));
            Config.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Password", TwoDo.Properties.Resources.password), newFile_Click));
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
            Character.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("New Character", TwoDo.Properties.Resources.addchar), newFile_Click));
            Character.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Set Attributes", TwoDo.Properties.Resources.atributes), newFile_Click));
            Character.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Set Sprites", TwoDo.Properties.Resources.sprite), newFile_Click));
            Character.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Set Animation", TwoDo.Properties.Resources.animation), newFile_Click));
            Character.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Add Lore", TwoDo.Properties.Resources.addlore), newFile_Click));
            Character.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Add Skill", TwoDo.Properties.Resources.addskill), newFile_Click));
            return Character;
        }

        private static ToolStripItem AddMapMenu()
        {
            var Map = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Map");
            Map.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("New Map", TwoDo.Properties.Resources.map), newFile_Click));
            Map.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Add Link", TwoDo.Properties.Resources.maplink), newFile_Click));
            Map.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Add Characters", TwoDo.Properties.Resources.addchar), newFile_Click));
            Map.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Add Itens", TwoDo.Properties.Resources.item), newFile_Click));
            Map.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Add Quest", TwoDo.Properties.Resources.quest), newFile_Click));
            Map.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Spawn Point", TwoDo.Properties.Resources.spawnPoint), newFile_Click));
            return Map;
        }

        private static ToolStripItem AddEditMenu()
        {
            var Edit = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Edit");
            Edit.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Undo", TwoDo.Properties.Resources.undo), newFile_Click));
            Edit.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Redo", TwoDo.Properties.Resources.redo), newFile_Click));
            Edit.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Duplicate", TwoDo.Properties.Resources.duplicate), newFile_Click));
            Edit.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Delete", TwoDo.Properties.Resources.delete), newFile_Click));
            Edit.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Select All", TwoDo.Properties.Resources.selectAll), newFile_Click));
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
            File.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("New Project", TwoDo.Properties.Resources.newFile), newFile_Click));
            File.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Open Project", TwoDo.Properties.Resources.open), newFile_Click));
            File.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Rename Project"), newFile_Click));
            File.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Save", TwoDo.Properties.Resources.save), newFile_Click));
            File.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Save All"), newFile_Click));
            File.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Import", TwoDo.Properties.Resources.import), newFile_Click));
            File.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Export", TwoDo.Properties.Resources.export), newFile_Click));
            File.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem("Exit", TwoDo.Properties.Resources.exit), exit_Click));
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
            twoDoMainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.newFile));
            twoDoMainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.open));
            twoDoMainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.save));
            twoDoMainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.save)); //save all -- find an icon
            twoDoMainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.undo));
            twoDoMainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.redo));
            twoDoMainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.selectAll));
            twoDoMainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.addchar));
            twoDoMainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.map));
            twoDoMainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.maplink));
            twoDoMainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.addskill));
            twoDoMainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.list));
            twoDoMainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.item));
            twoDoMainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.addlore));
            twoDoMainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.quest));
            twoDoMainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.completation));
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
            twoDoMainForm.SideBar.Buttons.Add(setButton("Character", TwoDo.Properties.Resources.addchar));
            twoDoMainForm.SideBar.Buttons.Add(setButton("Map", TwoDo.Properties.Resources.map));
            twoDoMainForm.SideBar.Buttons.Add(setButton("Skill", TwoDo.Properties.Resources.addskill));
            twoDoMainForm.SideBar.Buttons.Add(setButton("Item", TwoDo.Properties.Resources.item));
            twoDoMainForm.SideBar.Buttons.Add(setButton("Quest", TwoDo.Properties.Resources.quest));
            twoDoMainForm.SideBar.Buttons.Add(setButton("Lore", TwoDo.Properties.Resources.addlore));   
        }
    }
}
