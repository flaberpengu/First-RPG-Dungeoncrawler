using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSchoolV1
{
    public class Location
    {
        //Declare fields
        public Location locationToNorth;
        public Location locationToEast;
        public Location locationToSouth;
        public Location locationToWest;
        public string name;
        public List<Monster> monsters;
        public int chanceForEnemies;
        public int maxEnemies;

        //Constructor
        public Location(string gName, int gChance, int gMaxEnemies)
        {
            name = gName;
            chanceForEnemies = gChance;
            monsters = new List<Monster>();
            maxEnemies = gMaxEnemies;
        }
    }
}
