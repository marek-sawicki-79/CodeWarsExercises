using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnNegative
{
    public class Kata
    {
        public static int MakeNegative(int number)
        {
            int result;
            if (number <= 0)
            {
                result = number;
            }
            else
            {
                result = -number;
            }
            return result;
        }
    }
}
