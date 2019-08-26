using System;
using System.Collections.Generic;
using System.Text;

namespace Pillar_Kata
{
    class MarkdownController
    {
        public static bool AddItem(string name, double price, Dictionary<string, MarkdownItem> markdownList, double amount = 1)
        {
            StoreItem storeItem = GroceryProduct.Produce()[name];

            if(storeItem is null)
            {
                return false;
            }

            if (ItemExists(name, markdownList))
            {
                markdownList[name].quantity += amount;
                markdownList[name].unitPrice = price;
            }
            else
            {
                MarkdownItem markdownItem = new MarkdownItem(price, amount);
                markdownItem.soldBy = storeItem.soldBy;
                
                markdownList.Add(name, markdownItem);
            }

            return true;
        }

        public static bool ItemExists(string name, Dictionary<string, MarkdownItem> markdownList)
        {
            return markdownList.ContainsKey(name);
        }

        public static void AddItem(Dictionary<string, MarkdownItem> markdownList)
        {
            string name = StoreItemController.GetItem(markdownList);

            double amount = 0;

            while (!double.TryParse(UserInput.GetInput("Amount: "), out amount))
            {
                UserInput.Message("Not a valid amount!");
            }

            ///add do while here
            double price = 0;

            while (!double.TryParse(UserInput.GetInput("New price: "), out price))
            {
                UserInput.Message("Not a valid price!");
            }

            markdownList.Add(name, new MarkdownItem(price, amount));
        }

        public static void ShowMarkdownList(Dictionary<string, MarkdownItem> markdownList)
        {
            MarkdownView.ShowList(markdownList);
        }
    }
}
