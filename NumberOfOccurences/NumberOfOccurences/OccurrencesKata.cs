using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfOccurences
{
    public class OccurrencesKata
    {
        public static int NumberOfOccurrences(int x, int[] xs)
        {
            return xs.Count(n => n == x);
        }
    }
}
