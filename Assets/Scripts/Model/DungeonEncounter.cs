using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Model
{
    class DungeonEncounter
    {
        private string name;
        private string category;
        private string iconName;
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private float location;

        public DungeonEncounter()
        {
            this.description = "This is a description.";
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public string IconName
        {
            get { return iconName; }
            set { iconName = value; }
        }

        public float Location
        {
            get { return location; }
            set { location = value; }
        }


    }
}
