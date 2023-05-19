using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvensAndOdds
{
    public static class Kata
    {
        public static string EvensAndOdds(int num)
        {
            return(num % 2 == 0) ? Convert.ToString(num, 2) : num.ToString("x");
        }
    }
}
