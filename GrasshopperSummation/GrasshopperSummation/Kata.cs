using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrasshopperSummation
{
    public class Kata
    {
        public static int summation(int num)
        {
            int result = 0;
            for(int i = 1; i <= num; i++)
            {
                result = result + i;
            }
            return result;
        }
    }
}
