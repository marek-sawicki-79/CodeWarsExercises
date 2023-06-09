using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundUpTo5
{
    public class Kata
    {
        public static int RoundToNext5(int n)
        {
            while(n % 5 != 0) n++;
            return n;
        }
    }
}
