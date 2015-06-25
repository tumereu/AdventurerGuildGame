using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Model
{
    class Dungeon
    {
        public static readonly string[] hazardousnessLevels = 
        {
            "Safe","Precarious","Dangerous","Perilous","Treacherous"
        };

        public static readonly string[] enviroments =
        {
            "Plains","Crypt","Sewer","Forest","Prison","Tomb","Swamp"
        };

        private string name;
        private int hazardousness;
        private int recommendedLevel;
        private string enviroment;

        public Dungeon()
        {

        }

        public string Enviroment
        {
            get { return enviroment; }
            set { enviroment = value; }
        }

        public int RecommendedLevel
        {
            get { return recommendedLevel; }
            set { recommendedLevel = value; }
        }

        public int Hazardousness
        {
            get { return hazardousness; }
            set { hazardousness = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string GetDescription()
        {
            return this.Name + "\n" + "Level: " + this.recommendedLevel;
        }
    }
}
