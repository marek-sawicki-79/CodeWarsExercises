using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortOutMenFromBoys
{
    public class Kata
    {
        public static int[] MenFromBoys(int[] a)
        {
            HashSet<int> oddNum = new HashSet<int>();
            HashSet<int> evenNum = new HashSet<int>();
            foreach (int number in a)
            {
                if(number % 2 != 0)
                {
                    oddNum.Add(number);
                }
                else
                {
                    evenNum.Add(number);
                }
            }
            int[] sortedEven = evenNum.OrderBy(x => x).ToArray();
            int[] sortedOdd = oddNum.OrderByDescending(x => x).ToArray();
            int[] result = sortedEven.Concat(sortedOdd).ToArray();
            return result;
        }
    }
}
