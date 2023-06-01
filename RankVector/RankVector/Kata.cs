using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RankVector
{
    public class Kata
    {
        public static int[] Ranks(int[] ranks)
        {
            int[] sorted = ranks.ToArray();
            Array.Sort(sorted, (x, y) => y.CompareTo(x));
            return ranks.Select(v => Array.IndexOf(sorted, v) + 1).ToArray();
        }
    }
}

