using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDoInterfaces
{    
    public interface ITweDoTypes
    { }

    public enum ElementTypes
    {
        Neutral = 0,
        Fire,
        Water,
        Earth,
        Wind,
        Ice,
        Thunder,
        Ligth,
        Dark,
        Poison,
        Ghost,
        Psych
    }

    public enum ResistanceType
    {
        Absorb = 0,
        Reflect,
        Immunity,
        [Description("25%")]
        Res3,
        [Description("50%")]
        Res2,
        [Description("75%")]
        Res1,
        [Description("100%")]
        Neutral,
        [Description("125%")]
        Weak1,
        [Description("150%")]
        Weak2,
        [Description("175%")]
        Weak3,
        [Description("200%")]
        Weak4
    }

    public enum ItemCategoryType
    { 
        Loot = 0,
        Equip, 
        Material, 
        Consumable, 
        Collectable, 
        Key 
    }
}
