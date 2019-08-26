using System;
using System.Collections.Generic;
using System.Text;

namespace Pillar_Kata
{
    class StoreItemView
    {
        public static string GetItemCategory()
        {
            Console.WriteLine("1. Produce");
            Console.WriteLine("2. Meat");
            Console.WriteLine("3. Beverage");
            Console.WriteLine("4. Bread");
            Console.WriteLine("5. Cleaning Supplies");

            return UserInput.GetInput("Enter item category:");
        }
    }
}
