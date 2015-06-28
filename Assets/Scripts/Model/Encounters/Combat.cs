using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Model.Encounters
{
    class Combat : DungeonEncounter
    {
        public Combat()
        {
            this.Name = "Combat";
            this.Category = "Combat";
            this.IconName = "Sprites/Gui/skull_icon";
        }
    }
}
