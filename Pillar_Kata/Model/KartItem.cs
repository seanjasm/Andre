using System;
using System.Collections.Generic;
using System.Text;

namespace Pillar_Kata
{
    public class KartItem : Item
    {
        public double subtotal { get; set; }

        public Dictionary<string, KartItem> kartItems;

        public KartItem() : base(0, 0)
        {
            kartItems = new Dictionary<string, KartItem>();
            subtotal = 0;
        }

        public KartItem(double amount, double price) : base(amount, price)
        {
            subtotal = quantity * price;
        }

        public double AddItemToKart(string name, double num, Dictionary<string, MarkdownItem> markdownItem)
        {
            Dictionary<string, StoreItem> productList = GroceryProduct.Produce();

            if (productList.Count > 0)
            {
                // trying to get value double
                if (productList.TryGetValue(name, out StoreItem storeItem))
                {
                    //if item does not exist then we add to kart // else take that item and add it to our quantity already there
                    if (!kartItems.ContainsKey(name))
                    {
                        //Item does not exists, so added it to list
                        kartItems.Add(name, new KartItem(num, PriceSelector.GetItemPrice(name, markdownItem)));
                    }
                    else
                    {
                        //If item exists increment quantity and subtotal per item
                        kartItems[name].quantity += num;
                        kartItems[name].subtotal += num * kartItems[name].unitPrice;
                    }

                    return kartItems[name].subtotal;
                }
            }

            return 0;
        }

        public double RemoveItemFromKart(string name, double num)
        {
            //Get item from Kart
            if (!kartItems.TryGetValue(name, out KartItem item))
            {
                item.quantity -= num;
                return item.quantity;
            }

            return 0;
        }

        public Dictionary<string, KartItem> GetKartItems()
        {
            return kartItems;
        }
    }
}
