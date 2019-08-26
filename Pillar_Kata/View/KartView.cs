using System;
using System.Collections.Generic;
using System.Text;

namespace Pillar_Kata
{
    class KartView
    {
        public static void DisplayItemKey(IEnumerable<KeyValuePair<string, StoreItem>> items, Dictionary<string, MarkdownItem> markdownList)
        {
            int count = 1;
            double price = 0;

            foreach (var item in items)
            {
                price = PriceSelector.GetItemPrice(item.Key, markdownList);
                price = price > 0 ? price : item.Value.unitPrice;

                Console.WriteLine($"{count} ........ {item.Key} @ " +
                    $"{price:C2}/{item.Value.soldBy.ToString()}");
                count++;
                price = -1;
            }
            Console.WriteLine("");
        }
               
        public static void ShowKartItems(KartItem kartItems)
        {
            foreach(var item in kartItems.kartItems)
            {
                Console.WriteLine($"{item.Key}   {item.Value.quantity}@{item.Value.unitPrice:C2}/{item.Value.soldBy.ToString()}" +
                    $"    {item.Value.subtotal:C2}");
            }

            Console.ReadKey();
        }
    }
}
