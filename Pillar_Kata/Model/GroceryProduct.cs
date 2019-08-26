using System;
using System.Collections.Generic;
using System.Text;

namespace Pillar_Kata
{
    class GroceryProduct
    {
        public static Dictionary<string, StoreItem> Produce()
        {
            Dictionary<string, StoreItem> productList = new Dictionary<string, StoreItem>();
            productList.Add("Beets", new StoreItem("Produce", 10, .50, SoldBy.lb));
            productList.Add("Broccoli", new StoreItem("Produce", 10, .70, SoldBy.lb));
            productList.Add("Bag of Carrots", new StoreItem("Produce", 10, 3.99));
            productList.Add("Letttuces", new StoreItem("Produce", 10, 1.99));
            productList.Add("Okra", new StoreItem("Produce", 10, 4.39));
            productList.Add("Sweet Corn	", new StoreItem("Produce", 10, 4.39));
            productList.Add("Watermelon/Melons", new StoreItem("Produce", 10, 5.28));
            productList.Add("Rhubarb", new StoreItem("Produce", 10, 8.37));
            productList.Add("Green Beans", new StoreItem("Produce", 10, 8.33));
            productList.Add("Bokchoy", new StoreItem("Produce", 10, 7.45));
            productList.Add("Mint", new StoreItem("Produce", 10, .25));

            productList.Add("Kohlrabi", new StoreItem("Produce", 10, 20.00));
            productList.Add("Beef", new StoreItem("Meat", 10, 3.78, SoldBy.lb));
            productList.Add("Ribs", new StoreItem("Meat", 10, 3.50, SoldBy.lb));
            productList.Add("Flank", new StoreItem("Meat", 10, 9.45, SoldBy.lb));
            productList.Add("Brisket", new StoreItem("Meat", 10, 14.89, SoldBy.lb));
            productList.Add("Cow Tongnue", new StoreItem("Meat", 10, 11.46, SoldBy.lb));

            productList.Add("Coke", new StoreItem("Beverage", 10, 1.99));
            productList.Add("Pepsi", new StoreItem("Beverage", 10, 1.99));
            productList.Add("Fanta", new StoreItem("Beverage", 10, 1.99));
            productList.Add("Water", new StoreItem("Beverage", 10, 10.99));
            productList.Add("faygo", new StoreItem("Beverage", 10, .99));
            productList.Add("Coconut Water", new StoreItem("Beverage", 10, 4.76));
            productList.Add("Coffee", new StoreItem("Beverage", 10, 5.94));
            productList.Add("Juice", new StoreItem("Beverage", 10, 3.49));
            productList.Add("Kombucha", new StoreItem("Beverage", 10, 5.28));

            productList.Add("White Bread", new StoreItem("Bread", 10, 2.99));
            productList.Add("Wheat Bread", new StoreItem("Bread", 10, 3.00));
            productList.Add("Rye Bread", new StoreItem("Bread", 10, 5.99));
            productList.Add("Pumpernickel", new StoreItem("Bread", 10, 4.99));

            productList.Add("Clorox Wipes", new StoreItem("Cleaning Supply", 10, 16.62));
            productList.Add("All Purpose Cleaner", new StoreItem("Cleaning Supply", 10, 3.99));
            productList.Add("Bleach", new StoreItem("Cleaning Supply", 10, 4.85));
            productList.Add("Mop", new StoreItem("Cleaning Supply", 10, 1.00));
            productList.Add("Broom", new StoreItem("Cleaning Supply", 10, 3.00));
            productList.Add("Dust Pan", new StoreItem("Cleaning Supply", 10, 1.00));
            productList.Add("Bucket", new StoreItem("Cleaning Supply", 10, 2.09));
            return productList;
        }
    }
}
