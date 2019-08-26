using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pillar_Kata
{
    class MainMenuController
    {

        private static KartItem kartItem = new KartItem();
        private static Dictionary<string, MarkdownItem> markdownList = new Dictionary<string, MarkdownItem>();
        public static void Main()
        {
            bool proceed = true;

            while (proceed)
            {

               string choice = MainMenuView.MainMenu();

                if(choice == "1")
                {
                    ShowKartMenu(markdownList);
                }
                else if(choice == "2")
                {
                    MarkdownController.AddItem(markdownList);
                }
                else if (choice == "3")
                {
                    MarkdownController.ShowMarkdownList(markdownList);
                }
                else if(choice == "0")
                {
                    proceed = false;
                }
                



            }//ends progrom

            UserInput.Message("Thanks for shopping with Andre's ! Enjoy your products");
        }

        private static void ShowKartMenu(Dictionary<string, MarkdownItem> markdownList)
        {
            bool proceed = true;
            string name = "";

            while (proceed)
            {
                bool skip = false;

                switch (MainMenuView.KartMenu())
                {
                    case "0":
                        proceed = false;
                        skip = true;
                        break;
                    case "1":
                        UserInput.Message("I see you have chosen Produce : choose from our selection. What would you like to add to your cart.", false);
                        name = "Produce";

                        break;
                    case "2":
                        UserInput.Message("Meat it is ! Choose from our selection.", false);
                        name = "Meat";
                        break;
                    case "3":
                        UserInput.Message("Quench your thirst with these items", false);
                        name = "Beverage";
                        break;
                    case "4":
                        UserInput.Message("Choose from our wonderful selection of berads.", false);
                        name = "Bread";
                        break;
                    case "5":
                        UserInput.Message("I often tell people my house was clean yesterday, you should of been there !.... Lets get you some cleaning supplies so you wont have to say that.", false);
                        name = "Cleaning Supply";
                        break;

                    case "6":
                        KartController.DisplayKart(kartItem);
                        skip = true;
                        break;

                    case "7":
                        KartController.RemoveItem(kartItem);
                        skip = true;
                        break;
                    default:
                        skip = true;
                        break;
                }

                if(name != string.Empty)
                {
                    KartController.ListItemByCategory(name, markdownList);
                }

                if (!skip)
                {
                    KartController.AddItemToKart(kartItem, markdownList);
                }
            }
        }
        
    }
}
