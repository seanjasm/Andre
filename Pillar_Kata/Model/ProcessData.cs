using System;
using System.Collections.Generic;
using System.Text;

namespace Pillar_Kata
{
    class ProcessData
    {

        public static bool CheckNumber(int num)
        {
            if (num >= 1 && num <= 5)
            {
                return true;
            }
            return false;
        }
    }
}
