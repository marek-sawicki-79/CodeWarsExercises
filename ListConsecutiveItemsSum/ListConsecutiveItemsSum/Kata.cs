using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListConsecutiveItemsSum
{
    public class Kata
    {
        public static int SumNoDuplicates(int[] arr)
        {
            return arr.Where(x => arr.Count(n => n == x) == 1).Sum();
        }
    }
}
