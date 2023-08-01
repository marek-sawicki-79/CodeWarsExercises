using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterCoffee
{
    public class Kata
    {
        public static string Search(int budget, int[] prices)
        {
            return string.Join(",", prices.Where(p => p <= budget).OrderBy(p => p));
        }
    }
}
