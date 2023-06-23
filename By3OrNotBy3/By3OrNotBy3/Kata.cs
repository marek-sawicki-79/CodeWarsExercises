using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace By3OrNotBy3
{
    public static class Kata
    {
        public static bool DivisibleByThree(string n)
        {
            //int[] num = n.Select(c => int.Parse(c.ToString())).ToArray();
            //int sum = num.Sum();
            //if (sum % 3 == 0) return true;
            //else return false;

            return n.Sum(x => x) % 3 == 0;
        }
    }
}
