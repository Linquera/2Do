using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TwoDoInterfaces;
using TwoDoUtils;

namespace TwoDoLanguages
{
    public class Language : ITwoDoLanguage
    {
        public enum LanguageTypes { English, Portuguese, notDefined }
        private static ITwoDoLanguage instance;
        public static ITwoDoLanguage Instance
        {
            get
            {
                if (instance == null)
                {
                    SetLanguage(StringToLanguage(IniFile.Instance.IniReadValue("Options", "Language")));
                }
                return instance;
            }
        }

        public static void SetLanguage(LanguageTypes language)
        {            
            switch (language)
            {
                case LanguageTypes.notDefined:
                case LanguageTypes.English:
                    instance = new English();
                    break;

                case LanguageTypes.Portuguese:
                    instance = new Portuguese();
                    break;                
            }
        }

        public static LanguageTypes StringToLanguage(string language)
        {
            switch (language)
            {
                case "en-EU":
                    return LanguageTypes.English;
                case "pt-BR":
                    return LanguageTypes.Portuguese;
            }
            return LanguageTypes.notDefined;
        }

        public static string LanguageToString(LanguageTypes language)
        {
            switch (language)
            {
                case LanguageTypes.English:
                    return "en-EU";
                case LanguageTypes.Portuguese:
                    return "pt-BR";
            }
            return "";
        }

        public string _Language { get { return instance._Language; } }
        public string _English { get { return instance._English; } }
        public string _Portuguese { get { return instance._Portuguese; } }

        public string File { get { return instance.Scripts; } }
        public string Edit { get { return instance.Scripts; } }
        public string Character { get { return instance.Character; } }
        public string Map { get { return instance.Map; } }
        public string Skill { get { return instance.Skill; } }
        public string Item { get { return instance.Item; } }
        public string Quest { get { return instance.Quest; } }
        public string Lore { get { return instance.Lore; } }
        public string Options { get { return instance.Options; } }
        public string Misc { get { return instance.Misc; } }
                
        public string NewCharacter { get { return instance.NewCharacter; } }
        public string SetAttributes { get { return instance.SetAttributes; } }
        public string SetSprites { get { return instance.SetSprites; } }
        public string SetAnimation { get { return instance.SetAnimation; } }
        public string AddLore { get { return instance.AddLore; } }
        public string AddSkill { get { return instance.AddSkill; } }

        public string NewItem { get { return instance.NewItem; } }
        public string EditItem { get { return instance.EditItem; } }
        public string Search { get { return instance.Search; } }

        public string NewQuest { get { return instance.NewQuest; } }
        public string EditQuest { get { return instance.EditQuest; } }
        public string CheckCompletation { get { return instance.CheckCompletation; } }

        public string NewSkill { get { return instance.NewSkill; } }
        public string EditSkill { get { return instance.EditSkill; } }

        public string NewLore { get { return instance.NewLore; } }
        public string Storyline { get { return instance.Storyline; } }
        public string NewLinkWord { get { return instance.NewLinkWord; } }

        public string Editor { get { return instance.Editor; } }
        public string Preferences { get { return instance.Preferences; } }

        public string CustomAttributes { get { return instance.CustomAttributes; } }
        public string ElementTable { get { return instance.ElementTable; } }
        public string CustomCharacterType { get { return instance.CustomCharacterType; } }
        public string Scripts { get { return instance.Scripts; } }
        
        public string NewProject { get { return instance.Scripts; } }
        public string OpenProject { get { return instance.Scripts; } }
        public string RenameProject { get { return instance.Scripts; } }
        public string Save { get { return instance.Scripts; } }
        public string SaveAll { get { return instance.Scripts; } }
        public string Import { get { return instance.Scripts; } }
        public string Export { get { return instance.Scripts; } }
        public string Exit { get { return instance.Scripts; } }

        public string Undo { get { return instance.Scripts; } }
        public string Redo { get { return instance.Scripts; } }
        public string Duplicate { get { return instance.Scripts; } }
        public string Delete { get { return instance.Scripts; } }
        public string SelectAll { get { return instance.Scripts; } }
        public string Sort { get { return instance.Scripts; } }

        public string NewMap { get { return instance.Scripts; } }
        public string AddLink { get { return instance.Scripts; } }
        public string AddCharacters { get { return instance.Scripts; } }
        public string AddItens { get { return instance.Scripts; } }
        public string SpawnPoint { get { return instance.Scripts; } }

        public string Strength { get { return instance.Strength; } }
        public string Inteligence { get { return instance.Inteligence; } }
        public string Dexterity { get { return instance.Dexterity; } }
        public string Vitality { get { return instance.Vitality; } }
        public string BaseHP { get { return instance.BaseHP; } }
        public string BaseMP { get { return instance.BaseMP; } }
        public string Luck { get { return instance.Luck; } }
        public string MinLevel { get { return instance.MinLevel; } }
        public string Name { get { return instance.Name; } }
        public string SelectImage { get { return instance.SelectImage; } }
        public string Add { get { return instance.Add; } }
        public string Advanced { get { return instance.Advanced; } }

        //Elements
        public string Neutral { get { return instance.Neutral; } }
        public string Fire { get { return instance.Fire; } }
        public string Water { get { return instance.Water; } }
        public string Earth { get { return instance.Earth; } }
        public string Wind { get { return instance.Wind; } }
        public string Ice { get { return instance.Ice; } }
        public string Thunder { get { return instance.Thunder; } }
        public string Ligth { get { return instance.Ligth; } }
        public string Dark { get { return instance.Dark; } }
        public string Poison { get { return instance.Poison; } }
        public string Ghost { get { return instance.Ghost; } }
        public string Psych { get { return instance.Psych; } }

        //Resistances
        public string Absorb { get { return instance.Absorb; } }
        public string Reflect { get { return instance.Reflect; } }
        public string Immunity { get { return instance.Immunity; } }

        //Item Categories
        public string Loot { get { return instance.Loot; } }
        public string Equip { get { return instance.Equip; } }
        public string Material { get { return instance.Material; } }
        public string Consumable { get { return instance.Consumable; } }
        public string Collectable { get { return instance.Collectable; } }
        public string Key { get { return instance.Key; } }

        //Obtain
        public string Category { get { return instance.Category; } }
        public string HowToObtain { get { return instance.HowToObtain; } }
        public string Craft { get { return instance.Craft; } }
        public string Event { get { return instance.Event; } }
        public string LootOnGround { get { return instance.LootOnGround; } }
        public string MonsterDrop { get { return instance.MonsterDrop; } }
        public string NotObtainable { get { return instance.NotObtainable; } }
        public string Story { get { return instance.Story; } }
        public string TreasureBox { get { return instance.TreasureBox; } }

        //Formulas
        public string CalcFormula { get { return instance.CalcFormula; } }
        public string MinPAtk { get { return instance.MinPAtk; } }
        public string MaxPAtk { get { return instance.MaxPAtk; } }
        public string MinMAtk { get { return instance.MinMAtk; } }
        public string MaxMAtk { get { return instance.MaxMAtk; } }
        public string PDamage { get { return instance.PDamage; } }
        public string MDamage { get { return instance.MDamage; } }
    }
}