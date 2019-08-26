using System;
using System.Collections.Generic;
using System.Text;

namespace Pillar_Kata
{
    public class MarkdownItem : Item
    {
        public string name { get; set; }
        public MarkdownItem(double price, double amount) : base(amount, price)
        {

        }
    }
}