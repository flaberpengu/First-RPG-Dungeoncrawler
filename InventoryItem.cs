using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSchoolV1
{
    public class InventoryItem
    {
        public Item details;
        public int quantity;
        public InventoryItem(int num, Item itemGiven)
        {
            details = itemGiven;
            quantity = num;
        }
    }
}
