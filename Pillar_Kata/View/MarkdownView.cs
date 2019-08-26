using System;
using System.Collections.Generic;
using System.Text;

namespace Pillar_Kata
{
    class MarkdownView
    {
        public static void ShowList(Dictionary<string, MarkdownItem> items)
        {
            if (items != null || items.Count < 1)
            {
                foreach (var item in items)
                {
                    Console.WriteLine($"{item.Key}  @{item.Value.unitPrice:C2}");
                }
            }
            else
            {
                UserInput.Message("Nothing to show!");
            }
        }
        
    }
}
