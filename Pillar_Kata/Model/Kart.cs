using System;
using System.Collections.Generic;
using System.Text;

namespace Pillar_Kata
{
    class Kart
    {

        public static Dictionary<string, KartItem> kart = new Dictionary<string, KartItem>();

        public static double subtotal { get; set; }
        public static double AddProduce(string name, double num)
        {
            Dictionary<string, StoreItem> ProduceList = new Dictionary<string, StoreItem>();

            ProduceList = GroceryProduct.Produce();

            if (ProduceList.Count > 0)
            {
                // trying to get value double
                if (ProduceList.TryGetValue(name, out StoreItem storeItem))
                {
                    //if item does not exist then we add to kart // else take that item and add it to our quantity already there
                    if (!kart.TryGetValue(name, out KartItem item))
                    {
                        kart.Add(name, new KartItem(num, storeItem.unitPrice));
                    }
                    else
                    {
                        kart[name].quantity += num;
                    }

                    return kart[name].subtotal;
                }
            }

            return 0;
        }
    }
}
