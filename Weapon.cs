using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSchoolV1
{
    public class Weapon : Item
    {
        //Declare fields
        public string description;
        //Constructor
        public Weapon(string gName, int gDamage, string gDescription) : base(gName, gDamage)
        {
            description = gDescription;
        }
    }
}
