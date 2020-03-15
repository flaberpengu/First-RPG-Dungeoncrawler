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
        public int id;
        public string name;
        public int baseDamage;
        public int healthPoints;
        //Constructor
        public Monster(int gID, string gName, int gDamage, int gHealthPoints)
        {
            id = gID;
            name = gName;
            baseDamage = gDamage;
            healthPoints = gHealthPoints;
        }
    }
}
