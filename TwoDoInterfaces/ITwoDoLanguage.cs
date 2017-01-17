using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDoInterfaces
{    
    public interface ITwoDoLanguage
    {
        //Languages
        string _Language { get; }
        string _English { get; }
        string _Portuguese { get; }

        //Main menu buttons
        string File { get; }
        string Edit { get; }
        string Character { get; }
        string Map { get; }
        string Skill { get; }
        string Item { get; }
        string Quest { get; }
        string Lore { get; }
        string Options { get; }
        string Misc { get; }

        //ToolBar File
        string NewProject { get; }
        string OpenProject { get; }
        string RenameProject { get; }
        string Save { get; }
        string SaveAll { get; }
        string Import { get; }
        string Export { get; }
        string Exit { get; }

        //ToolBar Edit
        string Undo { get; }
        string Redo { get; }
        string Duplicate { get; }
        string Delete { get; }
        string SelectAll { get; }
        string Sort { get; }

        //ToolBar char
        string NewCharacter { get; }
        string SetAttributes { get; }
        string SetSprites { get; }
        string SetAnimation { get; }
        string AddLore { get; }
        string AddSkill { get; }

        //ToolBar Map
        string NewMap { get; }
        string AddLink { get; }
        string AddCharacters { get; }
        string AddItens { get; }
        string SpawnPoint { get; }

        //ToolBar Item
        string NewItem { get; }
        string EditItem { get; }
        string Search { get; }

        //ToolBar Quest
        string NewQuest { get; }
        string EditQuest { get; }
        string CheckCompletation { get; }

        //ToolBar Skill
        string NewSkill { get; }
        string EditSkill { get; }

        //ToolBar Lore
        string NewLore { get; }
        string Storyline { get; }
        string NewLinkWord { get; }

        //ToolBar Config
        string Editor { get; }
        string Preferences { get; }

        //ToolBar Misc.        
        string CustomAttributes { get; }
        string ElementTable { get; }
        string CustomCharacterType { get; }
        string Scripts { get; }

        //Characters attributes
        string Strength { get; }
        string Inteligence { get; }
        string Dexterity { get; }
        string Vitality { get; }
        string BaseHP { get; }
        string BaseMP { get; }
        string Luck { get; }
        string MinLevel { get; }
        string Name { get; }
        string SelectImage { get; }
        string Add { get; }
        string Advanced { get; }

        //Elements
        string Neutral { get; }
        string Fire { get; }
        string Water { get; }
        string Earth { get; }
        string Wind { get; }
        string Ice { get; }
        string Thunder { get; }
        string Ligth { get; }
        string Dark { get; }
        string Poison { get; }
        string Ghost { get; }
        string Psych { get; }

        //Resistances
        string Absorb { get; }
        string Reflect { get; }
        string Immunity { get; }

        //item Obtain
        string Category { get; }
        string HowToObtain { get; }
        string Craft { get; }
        string Event { get; }
        string LootOnGround { get; }
        string MonsterDrop { get; }
        string NotObtainable { get; }
        string Story { get; }
        string TreasureBox { get; }

        //Item Categories
        string Loot { get; }
        string Equip { get; }
        string Material { get; }
        string Consumable { get; }
        string Collectable { get; }
        string Key { get; }

        //Formulas
        string CalcFormula { get; }
        string MinPAtk { get; }
        string MaxPAtk { get; }
        string MinMAtk { get; }
        string MaxMAtk { get; }
        string PDamage { get; }
        string MDamage { get; }
            
    }
}
