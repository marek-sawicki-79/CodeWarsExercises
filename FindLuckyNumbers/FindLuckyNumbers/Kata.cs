using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindLuckyNumbers
{
    public class Kata
    {
        public static int[] FilterLucky(int[] x)
        {
            return x.Where(n => n.ToString().Contains("7")).ToArray();
        }
    }
}
