using System;
using System.Collections.Generic;
using System.Text;

namespace Pillar_Kata
{
    public class MainMenuView
    {
        public static string KartMenu()
        {
            ShowProductCategory();
            Console.WriteLine("6. Show Kart");
            Console.WriteLine("7. Remove Item");
            Console.WriteLine("0. Exit");
            return Console.ReadLine();
        }

        public static string MainMenu()
        {
            Console.WriteLine("1. Go to Kart");
            Console.WriteLine("2. Discount Item");
            Console.WriteLine("3. Display Discount Items");
            Console.WriteLine("0. Exit");
            return Console.ReadLine();
        }

        public static void ShowProductCategory()
        {
            Console.WriteLine("1. Produce");
            Console.WriteLine("2. Meat");
            Console.WriteLine("3. Beverage");
            Console.WriteLine("4. Bread");
            Console.WriteLine("5. Cleaning Supplies");
        }
    }
}
