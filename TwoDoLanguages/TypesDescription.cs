using System;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TwoDoInterfaces;
using TwoDoUtils;

namespace TwoDoLanguages
{
    public static class TypesDescription
    {
        public static string GetDescription(this ItemCategoryType type)
        {
            switch (type)
            {
                case ItemCategoryType.Loot: return Language.Instance.Loot;
                case ItemCategoryType.Equip: return Language.Instance.Equip;
                case ItemCategoryType.Consumable: return Language.Instance.Consumable;
                case ItemCategoryType.Collectable: return Language.Instance.Collectable;
                case ItemCategoryType.Material: return Language.Instance.Material;
                case ItemCategoryType.Key: return Language.Instance.Key;
            }
            return string.Empty;
        }

        public static string GetDescription(this ElementTypes element)
        {
            switch (element)
            {
                case ElementTypes.Neutral: return Language.Instance.Neutral;
                case ElementTypes.Fire: return Language.Instance.Fire;
                case ElementTypes.Water: return Language.Instance.Water;
                case ElementTypes.Wind: return Language.Instance.Wind;
                case ElementTypes.Earth: return Language.Instance.Earth;
                case ElementTypes.Ligth: return Language.Instance.Ligth;
                case ElementTypes.Dark: return Language.Instance.Dark;
                case ElementTypes.Poison: return Language.Instance.Poison;
                case ElementTypes.Psych: return Language.Instance.Psych;
                case ElementTypes.Ghost: return Language.Instance.Ghost;
                case ElementTypes.Thunder: return Language.Instance.Thunder;
                case ElementTypes.Ice: return Language.Instance.Ice;
            }
            return string.Empty;
        }

        public static string GetDescription(this ResistanceType resistance)
        {
            switch (resistance)
            {
                case ResistanceType.Absorb: return Language.Instance.Absorb;
                case ResistanceType.Reflect: return Language.Instance.Reflect;
                case ResistanceType.Immunity: return Language.Instance.Immunity;
                case ResistanceType.Res3: return ResistanceType.Res3.GetAttributeOfType<DescriptionAttribute>().Description;
                case ResistanceType.Res2: return ResistanceType.Res2.GetAttributeOfType<DescriptionAttribute>().Description;
                case ResistanceType.Res1: return ResistanceType.Res1.GetAttributeOfType<DescriptionAttribute>().Description;
                case ResistanceType.Neutral: return ResistanceType.Neutral.GetAttributeOfType<DescriptionAttribute>().Description;
                case ResistanceType.Weak1: return ResistanceType.Weak1.GetAttributeOfType<DescriptionAttribute>().Description;
                case ResistanceType.Weak2: return ResistanceType.Weak2.GetAttributeOfType<DescriptionAttribute>().Description;
                case ResistanceType.Weak3: return ResistanceType.Weak3.GetAttributeOfType<DescriptionAttribute>().Description;
                case ResistanceType.Weak4: return ResistanceType.Weak4.GetAttributeOfType<DescriptionAttribute>().Description;
            }
            return string.Empty;
        }
    }
}
