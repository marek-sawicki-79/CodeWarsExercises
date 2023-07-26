using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreviousMultipleOf3
{
    public static class Kata
    {
        public static int? PreviousMultipleOfThree(int n)
        {
            int? result = null;
            while (n.ToString().Length > 0)
            {
                if (n % 3 == 0)
                {
                    result = n;
                    break;
                }
                n /= 10;
            }
            if (result == 0)
            {
                result = null;
            }
            return result;
        }
    }
}
