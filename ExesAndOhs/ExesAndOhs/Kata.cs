using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExesAndOhs
{
    public static class Kata
    {
        public static bool XO(string input)
        {
            char exes = 'x';
            char ohs = 'o';
            int xCount = input.ToLower().Count(c => c == exes);
            int oCount = input.ToLower().Count(c => c == ohs);
            if (xCount == oCount) return true;
            else return false;
        }
    }
}
