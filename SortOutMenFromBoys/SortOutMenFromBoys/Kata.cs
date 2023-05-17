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
            List<int> oddNum = new List<int>();
            List<int> evenNum = new List<int>();
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
            oddNum.Sort((a, b) => b.CompareTo(a));
            evenNum.Sort();
            List<int> result = evenNum.Concat(oddNum).ToList();
            return result.ToArray();
        }
    }
}
