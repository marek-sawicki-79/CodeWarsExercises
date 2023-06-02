using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescendingOrder
{
    public static class Kata
    {
        public static int DescendingOrder(int num)
        {
            string digits = num.ToString();
            char[] sortedNums = digits.OrderByDescending(x => x).ToArray();
            string sortedNum = new string(sortedNums);
            return int.Parse(sortedNum);
        }
    }
}
