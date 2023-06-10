using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNumbers
{
    public class Kata
    {
        public static int[] SortNumbers(int[] nums)
        {
            if (nums == null) return new int[0];
            else
            {
                Array.Sort(nums);
                return nums;
            }
        }
    }
}
