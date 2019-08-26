using System;
using System.Collections.Generic;
using System.Text;

namespace Pillar_Kata
{
    class PriceSelector
    {
        public static double GetItemPrice(string name, Dictionary<string, MarkdownItem> markdownList)
        {
            //double price = 0;

            if (markdownList.ContainsKey(name))
            {
                return markdownList[name].unitPrice;
            }
            return GroceryProduct.Produce()[name].unitPrice;
        }

    }
}
