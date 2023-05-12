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
            return (lst.Length == 0 || lst.Length == 1) ? 0 : lst.Max() - lst.Min();
        }
    }
}
