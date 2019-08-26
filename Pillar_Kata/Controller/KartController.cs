using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pillar_Kata
{
    class KartController
    {
        public static void ListItemByCategory(string category, Dictionary<string, MarkdownItem>markdownList)
        {
            //Using LinQ to get all the key for items by category
            var items = from item in GroceryProduct.Produce()
                        where item.Value.category == category
                        select item;
            KartView.DisplayItemKey(items, markdownList);

        }
        public static void RemoveItem(KartItem kart)
        {
            if (kart.kartItems.Count == 1)
            {
                //Use LinQ to retrieve the key of the first item
                string key = (from item in kart.kartItems
                       select item.Key).FirstOrDefault();

                RemoveItemByName(kart, key);
                Console.ReadLine();
            }
            else if (kart.kartItems.Count > 0)
            {
                DisplayKart(kart);
                RemoveItemByName(kart, UserInput.GetInput("Enter name of item to remove:"));
                Console.ReadLine();
            }
            else
            {
                UserInput.Message("Nothing to delete!");
                return;
            }
        }

        public static void DisplayKart(KartItem kartItems)
        {
            if (kartItems.kartItems.Count > 0)
            {
                KartView.ShowKartItems(kartItems);
            }
            else
            {
                UserInput.Message("Nothing to display..");
            }
        }

        public static void RemoveItemByName(KartItem kart, string name)
        {
            if(!kart.kartItems.ContainsKey(name))
            {
                UserInput.Message("Item not found...");
                return;
            }

            //If quantity is one, then remove item from the dictionary list
            if (kart.kartItems[name].quantity <= 1)
            {
                kart.kartItems.Remove(name);
            }
            else
            {
                //Gets the amount to remove if greater than 1
                if (double.TryParse(UserInput.GetInput("Enter amount to remove:"), out double amount))
                {

                    //If the amount to be deleted is greater than or equal the amount in the cart
                    //Then remove the item from the cart
                    if (kart.kartItems[name].quantity <= amount)
                    {
                        kart.kartItems.Remove(name);
                    }
                    else
                    {
                        //Otherwise decrement the item quantity 
                        kart.kartItems[name].quantity -= amount;
                    }
                    Console.WriteLine("Done..");
                }
                else
                {
                    UserInput.Message("Not a valid number unit");
                }
            }
        }


        public static void AddItemToKart(KartItem kartItem, Dictionary<string, MarkdownItem> markdownItem)
        {
            string name = UserInput.GetInput("Enter name:");

            //Ensures that the name is valid. Case sensitive
            while (!StoreItemController.IsItemNameValid(name))
            {
                UserInput.Message("Item name is not valid. Names are case sensitive.", false);
                name = UserInput.GetInput("Enter name:");
            }
            double amount = 0;

            while (!double.TryParse(UserInput.GetInput("Amount:"), out amount))
            {
                UserInput.Message("not a valid amount:", false);
            }

            kartItem.AddItemToKart(name, amount, markdownItem);
        }

    }        
}
