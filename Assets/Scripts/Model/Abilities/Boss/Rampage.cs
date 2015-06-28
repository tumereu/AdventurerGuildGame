using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Model.Abilities.Boss
{
    class Rampage : Ability
    {

        private int damageIncrease = 10;

        public Rampage()
        {
            this.Name = "Rampage";
            this.Cooldown = 0;
            this.IsPassive = true;
        }

        override protected string GetDescription()
        {
            string desc = "Each attack increases your\n" +
                "damage by <color=" + Damage.ColorForElement(Damage.PHYSICAL) + ">" + damageIncrease + "%</color>.";
            return desc;
        }
    }
}
