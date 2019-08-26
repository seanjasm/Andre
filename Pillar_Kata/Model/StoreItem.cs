using System;
using System.Collections.Generic;
using System.Text;

namespace Pillar_Kata
{
    
    public class StoreItem : Item
    {
        public string category { get; set; }

        public StoreItem(string category, double quantity, double price, SoldBy soldBy = SoldBy.single):base(quantity,price)
        {
            this.category = category;
        }
    }

    
}
