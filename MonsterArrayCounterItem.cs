using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSchoolV1
{
    public class MonsterArrayCounterItem
    {
        public string monsterName;
        public int count;
        public MonsterArrayCounterItem(string gName, int gCount)
        {
            monsterName = gName;
            count = gCount;
        }
    }
}
