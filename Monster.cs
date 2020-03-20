using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSchoolV1
{
    public class Monster
    {
        //Declare fields
        public int localID;
        public int monsterID;
        public string name;
        public int baseDamage;
        public int healthPoints;
        public string cbMonsterName;
        public int localNumber;

        //Constructor
        public Monster(int gLID, int gID, string gName, int gDamage, int gHealthPoints)
        {
            localID = gLID;
            monsterID = gID;
            name = gName;
            baseDamage = gDamage;
            healthPoints = gHealthPoints;
        }
    }
}
