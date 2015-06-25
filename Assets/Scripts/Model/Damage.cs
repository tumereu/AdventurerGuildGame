using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Model
{
    class Damage
    {
        public static readonly string PHYSICAL = "Physical";
        public static readonly string FROST = "Frost";
        public static readonly string FIRE = "Fire";
        public static readonly string LIGHTNING = "Lightning";
        public static readonly string ARCANE = "Arcane";
        public static readonly string DARK = "Dark";
        public static readonly string HOLY = "Holy";
        public static readonly string POISON = "Poison";

        private static readonly Dictionary<string, int> colorForElement = new Dictionary<string, int>()
        {
            {PHYSICAL, 0x6E0000},
            {FROST, 0x36FFEB},
            {FIRE, 0xFF7700},
            {LIGHTNING, 0xFFEA00},
            {ARCANE, 0xE100FF},
            {DARK, 0x333333},
            {HOLY, 0xF8FFAD},
            {POISON, 0x09B000}
        };

        private string damageType;
        private int minDamage;
        private int maxDamage;

        public Damage(int min, int max, string type)
        {
            this.minDamage = min;
            this.maxDamage = max;
            this.damageType = type;
        }

        public string DamageType
        {
            get { return damageType; }
            set { damageType = value; }
        }

        public int MaxDamage
        {
            get { return maxDamage; }
            set { maxDamage = value; }
        }

        public int MinDamage
        {
            get { return minDamage; }
            set { minDamage = value; }
        }

        public string Text()
        {
            return "<color=" + Color() + ">" + this.minDamage + "-" + this.maxDamage + " " + this.damageType + " damage</color>";
        }

        public int Color()
        {
            return colorForElement[this.damageType];
        }

        public static int ColorForElement(string element) {
            return colorForElement[element];
        }

    }
}
