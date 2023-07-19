using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestElements
{
    public class Kata
    {
        public static List<int> Largest(int n, List<int> xs)
        {
            return xs.OrderByDescending(x => x).Take(n).ToList();
        }
    }
}
