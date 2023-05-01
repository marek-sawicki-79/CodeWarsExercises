using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FindNextPerfectSqare
{
    public class Kata
    {
        public static long FindNextSquare(long num)
        {
            long check = (long)Math.Sqrt(num);
            long result = 0;
            if (check * check != num)
            {
                return -1;
            }
            check++;
            result = (check * check);
            return result;
        }
    }
}
