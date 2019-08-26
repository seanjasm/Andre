using System;
using System.Collections.Generic;
using System.Text;

namespace Pillar_Kata
{
    class StoreItemController
    {
        public static string GetItem(Dictionary<string, MarkdownItem> markdownList)
        {
            string category = "";

            switch (StoreItemView.GetItemCategory())
            {

                case "1":
                    UserInput.Message("I see you have chosen Produce : choose from our selection. What would you like to add to your cart.", false);
                    category = "Produce";

                    break;
                case "2":
                    UserInput.Message("Meat it is ! Choose from our selection.", false);
                    category = "Meat";
                    break;
                case "3":
                    UserInput.Message("Quench your thirst with these items", false);
                    category = "Beverage";
                    break;
                case "4":
                    UserInput.Message("Choose from our wonderful selection of berads.", false);
                    category = "Bread";
                    break;
                case "5":
                    UserInput.Message("I often tell people my house was clean yesterday, you should of been there !.... Lets get you some cleaning supplies so you wont have to say that.", false);
                    category = "Cleaning Supply";
                    break;

                default:

                    UserInput.Message("Not valid selecton.", false);

                    break;
            }

            if (category != string.Empty)
            {
                KartController.ListItemByCategory(category, markdownList);
            }

            string name = UserInput.GetInput("Enter name of item:");

            while(!IsItemNameValid(name))
            {
                UserInput.Message("Not a valid name. Names are case sensitive.", false);
                name = UserInput.GetInput("Enter name of item:");
            }

            return name;
        }

        public static bool IsItemNameValid(string name)
        {
            return GroceryProduct.Produce().ContainsKey(name);            
        }

    }
}
