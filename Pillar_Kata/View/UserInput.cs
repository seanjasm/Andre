using System;
using System.Collections.Generic;
using System.Text;

namespace Pillar_Kata
{
    class UserInput
    {
        public static void Message(string message, bool addPause = true, bool clearScr = false)
        {
            Console.Write(message);
            if (addPause)
            {
                Console.Write("\n\nPress any key to continue.....\n\n");
                Console.ReadKey();
            }

            if(clearScr)
            {
                Console.Clear();
            }
        }

        public static string GetInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

    }
}
