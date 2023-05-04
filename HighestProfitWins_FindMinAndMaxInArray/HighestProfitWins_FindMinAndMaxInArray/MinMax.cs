using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighestProfitWins_FindMinAndMaxInArray
{
    public class MinMax
    {
        public static int[] minMax(int[] lst)
        {
            int[] result = new int[2];
            result[0] = lst.Min();
            result[1] = lst.Max();
            return result;
        }
    }
}
