using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using TwoDoCharacter;
using TwoDoCustomForm;
using TwoDoInterfaces;
using TwoDoItem;
using TwoDoLore;
using TwoDoMap;
using TwoDoQuest;
using TwoDoSkill;
using TwoDoUtils;
using TwoDoLanguages;

namespace TwoDo
{
    public class ControlsController
    {
        private TwoDoMainForm mainForm;
        public CustomXml CharacterNode { get; set; }
        public CustomXml MapNode { get; set; }
        public CustomXml SkillNode { get; set; }
        public CustomXml ItemNode { get; set; }
        public CustomXml QuestNode { get; set; }
        public CustomXml LoreNode { get; set; }
        public bool PendingSave = false;
        
        public ControlsController(TwoDoMainForm form)
        {
            mainForm = form;
            AddMenus();
            AddToolButtons();
            AddSideButtons();
            mainForm.ShowButtons();
            CreateXmls();
        }

        private void CreateXmls()
        {
            CharacterNode = new CustomXml(CharacterForm.Root);
            //MapNode = new CustomXml("");
            //SkillNode = new CustomXml("");
            //ItemNode = new CustomXml("");
            //QuestNode = new CustomXml("");
            //LoreNode = new CustomXml("");
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
            var Skill = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.Skill);
            Skill.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.NewSkill, TwoDo.Properties.Resources.sSkill), notImplemented_Click));
            Skill.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.EditSkill), notImplemented_Click));
            Skill.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.AddLore, TwoDo.Properties.Resources.sLore), notImplemented_Click));
            Skill.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.Search, TwoDo.Properties.Resources.sSearch), notImplemented_Click));
            return Skill;
        }

        private ToolStripItem AddItensMenu()
        {
            var Items = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.Item);
            Items.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.NewItem, TwoDo.Properties.Resources.sItem), notImplemented_Click));
            Items.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.EditItem), notImplemented_Click));
            Items.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.AddLore, TwoDo.Properties.Resources.sLore), notImplemented_Click));
            Items.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.Search, TwoDo.Properties.Resources.sSearch), notImplemented_Click));
            return Items;
        }

        private ToolStripItem AddQuestMenu()
        {
            var Quest = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.Quest);
            Quest.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.NewQuest, TwoDo.Properties.Resources.sQuest), notImplemented_Click));
            Quest.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.EditQuest), notImplemented_Click));
            Quest.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.AddLore, TwoDo.Properties.Resources.sLore), notImplemented_Click));
            Quest.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.CheckCompletation, TwoDo.Properties.Resources.sCompletation), notImplemented_Click));
            return Quest;
        }

        private ToolStripItem AddLoreMenu()
        {
            var Lore = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.Lore);
            Lore.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.NewLore, TwoDo.Properties.Resources.sLore), notImplemented_Click));
            Lore.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.Storyline, TwoDo.Properties.Resources.sStoryline), notImplemented_Click));
            Lore.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.NewLinkWord), notImplemented_Click));
            return Lore;
        }

        private ToolStripItem AddConfigMenu()
        {
            var Config = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.Options);            
            Config.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.Preferences, TwoDo.Properties.Resources.sConfig), Preferences_click));
            Config.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.Editor, TwoDo.Properties.Resources.sEditor), notImplemented_Click));
            return Config;
        }        

        private ToolStripItem AddMiscMenu()
        {
            var Misc = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.Misc);
            Misc.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.CustomAttributes), notImplemented_Click));
            Misc.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.ElementTable), notImplemented_Click));
            Misc.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.CustomCharacterType), notImplemented_Click));
            Misc.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.Scripts), notImplemented_Click));
            return Misc;
        }

        private ToolStripItem AddCharacterMenu()
        {
            var Character = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.Character);
            Character.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.NewCharacter, TwoDo.Properties.Resources.sCharacter), notImplemented_Click));
            Character.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.SetAttributes, TwoDo.Properties.Resources.sAtributes), notImplemented_Click));
            Character.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.SetSprites, TwoDo.Properties.Resources.sSprite), notImplemented_Click));
            Character.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.SetAnimation, TwoDo.Properties.Resources.sAnimation), notImplemented_Click));
            Character.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.AddLore, TwoDo.Properties.Resources.sLore), notImplemented_Click));
            Character.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.AddSkill, TwoDo.Properties.Resources.sSkill), notImplemented_Click));
            return Character;
        }

        private ToolStripItem AddMapMenu()
        {
            var Map = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.Map);
            Map.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.NewMap, TwoDo.Properties.Resources.sMap), notImplemented_Click));
            Map.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.AddLink, TwoDo.Properties.Resources.sMaplink), notImplemented_Click));
            Map.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.AddCharacters, TwoDo.Properties.Resources.sCharacter), notImplemented_Click));
            Map.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.AddItens, TwoDo.Properties.Resources.sItem), notImplemented_Click));
            Map.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.SpawnPoint, TwoDo.Properties.Resources.sSpawnPoint), notImplemented_Click));
            return Map;
        }

        private ToolStripItem AddEditMenu()
        {
            var Edit = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.Edit);
            Edit.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.Undo, TwoDo.Properties.Resources.sUndo), notImplemented_Click));
            Edit.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.Redo, TwoDo.Properties.Resources.sRedo), notImplemented_Click));
            Edit.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.Duplicate, TwoDo.Properties.Resources.sDuplicate), notImplemented_Click));
            Edit.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.Delete, TwoDo.Properties.Resources.sDelete), notImplemented_Click));
            Edit.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.SelectAll, TwoDo.Properties.Resources.sSelectAll), notImplemented_Click));
            Edit.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.Sort), notImplemented_Click));
            return Edit;
        }

        private TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem VinculaEvento(TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem menu, EventHandler clickEvent)
        {
            menu.Click += clickEvent;
            return menu;
        }

        public TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem AddFileMenu()
        {
            var File = new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.File);
            File.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.NewProject, TwoDo.Properties.Resources.sNewFile), notImplemented_Click));
            File.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.OpenProject, TwoDo.Properties.Resources.sOpen), notImplemented_Click));
            File.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.RenameProject), notImplemented_Click));
            File.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.Save, TwoDo.Properties.Resources.sSave), notImplemented_Click));
            File.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.SaveAll), notImplemented_Click));
            File.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.Import, TwoDo.Properties.Resources.sImport), notImplemented_Click));
            File.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.Export, TwoDo.Properties.Resources.sExport), notImplemented_Click));
            File.DropDownItems.Add(VinculaEvento(new TwoDoCustomForm.CustomMenuStrip.CustomMenuStripItem(Language.Instance.Exit, TwoDo.Properties.Resources.sExit), exit_Click));
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
            mainForm.ToolBox.Buttons.Add(setButton("", TwoDo.Properties.Resources.mCharacter, NewCharacter_Click));
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
            /*if (PendingSave)
            {
                if(MessageBox.Show("Unsaved information will be lost. Save before close?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    return;
                }
            }*/
            mainForm.ProjectSave = new ProjectSave();
            OpenFileDialog op = new OpenFileDialog();
            op.InitialDirectory = "c:\\"; //save last open position
            op.Filter = "2Do files (*.2Do)|*.2Do";            
            op.RestoreDirectory = true;
            if(op.ShowDialog() == DialogResult.OK)
            {                
                try
                {
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(Base64Decode((string)ConvertByteArrayToObject(File.ReadAllBytes(op.FileName))));
                    var node = xml.DocumentElement.SelectSingleNode("//TwoDo");
                    mainForm.ProjectSave.LoadFromXml(node.GetNodeXmlOrEmpty("ProjectSave"));
                    CharacterNode.LoadXml(node.GetNodeXmlOrEmpty("CharacterForm"));
                    //MapNode.LoadXml(node.SelectSingleNode("MapForm").InnerXml);
                    //SkillNode.LoadXml(node.SelectSingleNode("SkillForm").InnerXml);
                    //ItemNode.LoadXml(node.SelectSingleNode("ItemForm").InnerXml);
                    //QuestNode.LoadXml(node.SelectSingleNode("QuestForm").InnerXml);
                    //LoreNode.LoadXml(node.SelectSingleNode("LoreForm").InnerXml);

                    ReloadOpenForms();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file: " + ex.Message);
                }
            }
        }

        private void ReloadOpenForms()
        {
            if (mainForm.CharForm != null) { mainForm.CharForm.LoadFromXml(CharacterNode.OuterXml); }
            /*if (mainForm.MapForm != null)  { mainForm.MapForm.LoadFromXml(CharacterNode.InnerXml); }
            if (mainForm.CharForm != null) { mainForm.CharForm.LoadFromXml(CharacterNode.InnerXml); }
            if (mainForm.CharForm != null) { mainForm.CharForm.LoadFromXml(CharacterNode.InnerXml); }
            if (mainForm.CharForm != null) { mainForm.CharForm.LoadFromXml(CharacterNode.InnerXml); }
            if (mainForm.CharForm != null) { mainForm.CharForm.LoadFromXml(CharacterNode.InnerXml); }
            if (mainForm.CharForm != null) { mainForm.CharForm.LoadFromXml(CharacterNode.InnerXml); }*/
        }

        private void save_Click(object sender, EventArgs e)
        {
            Save();
        }

        public void Save()
        {
            if (mainForm.ProjectSave == null)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "2Do files (*.2Do)|*.2Do";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    mainForm.ProjectSave = new ProjectSave();
                    mainForm.ProjectSave.Name = dialog.FileName;                    
                }
                else
                    return;
            }

            UpdateXmlNodes();
            CustomXml xml = new CustomXml("TwoDo");
            xml.Node(mainForm.ProjectSave.asXml());
            xml.Node(CharacterNode); //mainForm.CharForm.asXml());
            File.WriteAllBytes(mainForm.ProjectSave.Name, ConvertObjectToByteArray(Base64Encode(xml.InnerXml)));
            
            //for teste purpose
            File.WriteAllText(mainForm.ProjectSave.Name + ".xml", xml.InnerXml);
        }

        private void UpdateXmlNodes()
        {
            if (mainForm.CharForm != null) { CharacterNode = mainForm.CharForm.asXml(); }
            /*if (mainForm.MapForm != null)  { mainForm.MapForm.LoadFromXml(CharacterNode.InnerXml); }
            if (mainForm.CharForm != null) { mainForm.CharForm.LoadFromXml(CharacterNode.InnerXml); }
            if (mainForm.CharForm != null) { mainForm.CharForm.LoadFromXml(CharacterNode.InnerXml); }
            if (mainForm.CharForm != null) { mainForm.CharForm.LoadFromXml(CharacterNode.InnerXml); }
            if (mainForm.CharForm != null) { mainForm.CharForm.LoadFromXml(CharacterNode.InnerXml); }
            if (mainForm.CharForm != null) { mainForm.CharForm.LoadFromXml(CharacterNode.InnerXml); }*/
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
            mainForm.SideBar.Buttons.Add(setButton(Language.Instance.Character, TwoDo.Properties.Resources.bCharacter, CharacterForm_click));
            mainForm.SideBar.Buttons.Add(setButton(Language.Instance.Map, TwoDo.Properties.Resources.bMap, MapForm_click));
            mainForm.SideBar.Buttons.Add(setButton(Language.Instance.Skill, TwoDo.Properties.Resources.bSkill, SkillForm_click));
            mainForm.SideBar.Buttons.Add(setButton(Language.Instance.Item, TwoDo.Properties.Resources.bItem, ItemForm_click));
            mainForm.SideBar.Buttons.Add(setButton(Language.Instance.Quest, TwoDo.Properties.Resources.bQuest, QuestForm_click));
            mainForm.SideBar.Buttons.Add(setButton(Language.Instance.Lore, TwoDo.Properties.Resources.bLore, LoreForm_click));   
        }

        private void CharacterForm_click(object sender, EventArgs e)
        {
            if (mainForm.CharForm == null)
            {
                mainForm.CharForm = new CharacterForm(true);
                if (CharacterNode != null) { mainForm.CharForm.LoadFromXml(CharacterNode.OuterXml); }               
                OpenMdiForm(mainForm.CharForm);
            }
            else if (!mainForm.CharForm.Focused)
            {
                mainForm.CharForm.Focus();
            }
        }

        private void NewCharacter_Click(object sender, EventArgs e)
        {
            if (mainForm.CharForm == null)
            {
                mainForm.CharForm = new CharacterForm(true);
                if (CharacterNode != null) { mainForm.CharForm.LoadFromXml(CharacterNode.OuterXml); }
                setFormBounds(mainForm.CharForm);
            }
            var newCharForm = new NewCharacterForm();
            newCharForm.Save += mainForm.CharForm.newCharForm_Save;
            newCharForm.ShowDialog();
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
            setFormBounds(form);
            form.Show();
        }

        private void setFormBounds(Form form)
        {
            form.MdiParent = mainForm;
            form.Dock = DockStyle.Fill;
            (form as ITwoDoMdiForm).MdiExitClick += CloseMdiForm;
        }

        private void CloseMdiForm(object sender, EventArgs e)
        {
            //if (PendingSave)
            //{
                switch ((e as IMdiEventArgs).FormType)
                {
                    case MdiFormType.Character:                        
                        CharacterNode = mainForm.CharForm.asXml();
                        mainForm.CharForm = null;
                        break;
                    case MdiFormType.Map: mainForm.MapForm = null; break;
                    case MdiFormType.Skill: mainForm.SkillForm = null; break;
                    case MdiFormType.Items: mainForm.ItemForm = null; break;
                    case MdiFormType.Quest: mainForm.QuestForm = null; break;
                    case MdiFormType.Lore: mainForm.LoreForm = null; break;
                }
            //}
        }
        
        private string Base64Encode(string text)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(text);
            return System.Convert.ToBase64String(bytes);
        }

        private string Base64Decode(string base64EncodedText)
        {
            var bytes = System.Convert.FromBase64String(base64EncodedText);
            return System.Text.Encoding.UTF8.GetString(bytes);
        }

        private byte[] ConvertObjectToByteArray(object o)
        {
            BinaryFormatter binary = new BinaryFormatter();
            MemoryStream stream = new MemoryStream();
            binary.Serialize(stream, o);
            return stream.ToArray();
        }

        private object ConvertByteArrayToObject(byte[] bytes)
        {
            BinaryFormatter binary = new BinaryFormatter();
            Stream stream = new MemoryStream(bytes);
            return binary.Deserialize(stream);
        }

        private void Preferences_click(object sender, EventArgs e)
        {
            var OptionForm = new OptionsForm();
            OptionForm.ShowDialog();
        }
    }
}
