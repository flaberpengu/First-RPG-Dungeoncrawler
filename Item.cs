using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSchoolV1
{
    public class Item
    {
        public string name;
        public int baseDamage;
        public Item(string gName, int gBaseDamage)
        {
            name = gName;
            baseDamage = gBaseDamage;
        }
    }
}
