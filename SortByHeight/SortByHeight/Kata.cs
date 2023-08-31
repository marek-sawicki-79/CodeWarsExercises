using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortByHeight
{
    public class Kata
    {
        public int[] SortByHeight(int[] a)
        {
            var sorted = a.Where(x => x > 0).OrderBy(x => x).ToArray();
            int index = 0;
            return a.Select(x => (x <= 0) ? x : sorted[index++]).ToArray();
        }
    }
}
