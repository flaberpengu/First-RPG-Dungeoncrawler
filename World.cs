using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSchoolV1
{
    public class World
    {
        //Declare fields
        public Player player;
        public Location location0; //Used if no location in direction
        public Location location1;
        public Location location2;
        public Location location3;
        public Location location4;
        public Location location5;
        //Monster values
        const int MONST_SPIDER_ID = 1;
        const string MONST_SPIDER_NAME = "Spider";
        const int MONST_SPIDER_BASEDAMAGE = 3;
        const int MONST_SPIDER_HP = 20;

        public void AddMonster()
        {
            player.currentLocation.monsters.Add(new Monster(MONST_SPIDER_ID, MONST_SPIDER_NAME, MONST_SPIDER_BASEDAMAGE, MONST_SPIDER_HP));
        }
        public void InitialiseWorld()
        {
            //Initialise locations
            location0 = new Location("NONE",0);
            location1 = new Location("loc1",0);
            location2 = new Location("loc2",40);
            location3 = new Location("loc3",10);
            location4 = new Location("loc4",35);
            location5 = new Location("loc5",95);
            //Initialise player;
            player = new Player("Tester", 50, 0, location1);
            //Create basic weapon for player
            Weapon basicWeapon = new Weapon("Iron Sword", 5, "A basic iron sword");
            InventoryItem iiBasicWeapon = new InventoryItem(1, basicWeapon);
            player.inventory.Add(iiBasicWeapon);
            //Set locations around locations
            //location1
            location1.locationToNorth = location0;
            location1.locationToEast = location0;
            location1.locationToSouth = location3;
            location1.locationToWest = location0;
            //location2
            location2.locationToNorth = location0;
            location2.locationToEast = location3;
            location2.locationToSouth = location0;
            location2.locationToWest = location0;
            //location3
            location3.locationToNorth = location1;
            location3.locationToEast = location4;
            location3.locationToSouth = location5;
            location3.locationToWest = location2;
            //location4
            location4.locationToNorth = location0;
            location4.locationToEast = location0;
            location4.locationToSouth = location0;
            location4.locationToWest = location3;
            //location5
            location5.locationToNorth = location3;
            location5.locationToEast = location0;
            location5.locationToSouth = location0;
            location5.locationToWest = location0;
            //Set monsters in each location
            //location1
            //location2
            //location2.monsters.Add(new Monster(MONST_SPIDER_ID, MONST_SPIDER_NAME, MONST_SPIDER_BASEDAMAGE, MONST_SPIDER_HP));
        }
    }
}
