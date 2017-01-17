using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoDoInterfaces;

namespace TwoDoLanguages
{
    class English : ITwoDoLanguage
    {
        //Languages
        public string _Language { get { return "Language"; } }
        public string _English { get { return "English"; } }
        public string _Portuguese { get { return "Portuguese"; } }

        //Main menu buttons
        public string File { get { return "File"; } }
        public string Edit { get { return "Edit"; } }
        public string Character { get { return "Character"; } }
        public string Map { get { return "Map"; } }
        public string Skill { get { return "Skill"; } }
        public string Item { get { return "Item"; } }
        public string Quest { get { return "Quest"; } }
        public string Lore { get { return "Lore"; } }
        public string Options { get { return "Options"; } }
        public string Misc { get { return "Misc."; } }

        //Toolbar File
        public string NewProject { get { return "New Project"; } }
        public string OpenProject { get { return "Open Project"; } }
        public string RenameProject { get { return "Rename Project"; } }
        public string Save { get { return "Save"; } }
        public string SaveAll { get { return "Save All"; } }
        public string Import { get { return "Import"; } }
        public string Export { get { return "Export"; } }
        public string Exit { get { return "Exit"; } }

        //Toobar Edit
        public string Undo { get { return "Undo"; } }
        public string Redo { get { return "Redo"; } }
        public string Duplicate { get { return "Duplicate"; } }
        public string Delete { get { return "Delete"; } }
        public string SelectAll { get { return "Select All"; } }
        public string Sort { get { return "Sort"; } }

        //ToolBar Char
        public string NewCharacter { get { return "New Character"; } }
        public string SetAttributes { get { return "Set Attributes"; } }
        public string SetSprites { get { return "Set Sprites"; } }
        public string SetAnimation { get { return "Set Animation"; } }
        public string AddLore { get { return "Add Lore"; } }
        public string AddSkill { get { return "Add Skill"; } }

        //ToolBar Map
        public string NewMap { get { return "New Map"; } }
        public string AddLink { get { return "Add Link"; } }
        public string AddCharacters { get { return "Add Character"; } }
        public string AddItens { get { return "Add Item"; } }
        public string SpawnPoint { get { return "Spawpoint"; } }

        //ToolBar Item
        public string NewItem { get { return "New Item"; } }
        public string EditItem { get { return "Edit Item"; } }
        public string Search { get { return "Search"; } }

        //ToolBar Quest
        public string NewQuest { get { return "New Quest"; } }
        public string EditQuest { get { return "Edit Quest"; } }
        public string CheckCompletation { get { return "Check Completation"; } }

        //ToolBar Skill
        public string NewSkill { get { return "New Skill"; } }
        public string EditSkill { get { return "Edit Skill"; } }

        //ToolBar Lore
        public string NewLore { get { return "New Lore"; } }
        public string Storyline { get { return "StoryLine"; } }
        public string NewLinkWord { get { return "New Linkword"; } }

        //ToolBar Options
        public string Editor { get { return "Editor"; } }
        public string Preferences { get { return "Preferences"; } }

        //ToolBar Misc.
        public string CustomAttributes { get { return "Custom Attributes"; } }
        public string ElementTable { get { return "Element Table"; } }
        public string CustomCharacterType { get { return "Custom Character Type"; } }
        public string Scripts { get { return "Scripts"; } }

        //character attributes
        public string Strength { get { return "Strength"; } }
        public string Inteligence { get { return "Inteligence"; } }
        public string Dexterity { get { return "Dexterity"; } }
        public string Vitality { get { return "Vitality"; } }
        public string BaseHP { get { return "Base HP"; } }
        public string BaseMP { get { return "Base MP"; } }
        public string Luck { get { return "Luck"; } }
        public string MinLevel { get { return "Min. Level"; } }
        public string Name { get { return "Name"; } }
        public string SelectImage { get { return "Select Image"; } }
        public string Add { get { return "Add"; } }
        public string Advanced { get { return "Advanced"; } }
        
        //Elements
        public string Neutral { get { return "Neutral"; } }
        public string Fire { get { return "Fire"; } }
        public string Water { get { return "Water"; } }
        public string Earth { get { return "Earth"; } }
        public string Wind { get { return "Wind"; } }
        public string Ice { get { return "Ice"; } }
        public string Thunder { get { return "Thunder"; } }
        public string Ligth { get { return "Ligth"; } }
        public string Dark { get { return "Dark"; } }
        public string Poison { get { return "Poison"; } }
        public string Ghost { get { return "Ghost"; } }
        public string Psych { get { return "Psych"; } }

        //Resistances
        public string Absorb { get { return "Absorb"; } }
        public string Reflect { get { return "Reflect"; } }
        public string Immunity { get { return "Immunity"; } }

        //Item Categories
        public string Loot { get { return "Loot"; } }
        public string Equip { get { return "Equip"; } }
        public string Material { get { return "Material"; } }
        public string Consumable { get { return "Consumable"; } }
        public string Collectable { get { return "Collectable"; } }
        public string Key { get { return "Key"; } }

        //obtain
        public string Category { get { return "Category"; } }
        public string HowToObtain { get { return "How To Obtain"; } }
        public string Craft { get { return "Craft"; } }
        public string Event { get { return "Event"; } }
        public string LootOnGround { get { return "Loot On Ground"; } }
        public string MonsterDrop { get { return "Monster Drop"; } }
        public string NotObtainable { get { return "Not Obtainable"; } }
        public string Story { get { return "Story"; } }
        public string TreasureBox { get { return "Treasure Box"; } }

        //Formulas
        public string CalcFormula{ get { return "Calculation Formulas"; } }
        public string MinPAtk { get { return "Min Physical Attack"; } }
        public string MaxPAtk { get { return "Max Physical Attack"; } }
        public string MinMAtk { get { return "Min Magical Attack"; } }
        public string MaxMAtk { get { return "Max Magical Attack"; } }
        public string PDamage { get { return "Physical Damage"; } }
        public string MDamage { get { return "Magical Damage"; } }
    }
}
