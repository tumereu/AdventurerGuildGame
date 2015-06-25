using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Model
{
    abstract class Ability
    {
        private static readonly int cooldownColor = 0x6e6e6e;

        private string name;
        private int cooldown;
        private bool isPassive;
        protected int nameColor = 0xFFFFFF;

        public bool IsPassive
        {
            get { return isPassive; }
            set { isPassive = value; }
        }

        public int Cooldown
        {
            get { return cooldown; }
            set { cooldown = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        protected abstract string GetDescription();

        public string GetInfo()
        {
            string info = "<color=" + nameColor + ">" + name + "</color>";
            info += "           ";
            if (this.cooldown > 0)
            {
                string cd = "" + this.cooldown;
                if (cd.Length < 2)
                {
                    cd = "0" + cd;
                }
                cd = cd.Insert(cd.Length - 2, ".");
                info += "<color=" + cooldownColor + ">Cooldown: " + cd + "</color>";
            }
            if (this.isPassive)
            {
                info += "<color=" + cooldownColor + ">Passive</color>";
            }
            info += "\n\n";
            info += this.GetDescription();
            return info;
        }
    }
}
