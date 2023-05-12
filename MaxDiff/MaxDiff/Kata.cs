using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxDiff
{
    public class Kata
    {
        public static int MaxDiff(int[] lst)
        {
            if (lst.Length == 0 || lst.Length == 1) return 0;
            else return lst.Max() - lst.Min();
        }
    }
}
