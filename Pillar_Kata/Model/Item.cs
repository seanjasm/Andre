using System;
using System.Collections.Generic;
using System.Text;

namespace Pillar_Kata
{
    public enum SoldBy
    {
        lb,
        kg,
        single,
        cases
    }
    public class Item
    {
        public double quantity { get; set; }

        public double unitPrice { get; set; }

        public SoldBy soldBy { get; set; }

        public Item(double amount, double price, SoldBy soldBy = SoldBy.single)
        {
            quantity = amount;
            unitPrice = price;
        }

        public Item()
        {

        }
       
    }
}
