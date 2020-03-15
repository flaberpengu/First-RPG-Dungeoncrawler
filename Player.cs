using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSchoolV1
{
    public class Player
    {
        //Declare fields
        public string name;
        public int healthPoints;
        public int gold;
        public Location currentLocation;
        public List<InventoryItem> inventory;

        //Constructor
        public Player(string gName, int gHP, int gGold, Location gCurrentLocation)
        {
            name = gName;
            healthPoints = gHP;
            gold = gGold;
            currentLocation = gCurrentLocation;
            inventory = new List<InventoryItem>();
        }
    }
}
