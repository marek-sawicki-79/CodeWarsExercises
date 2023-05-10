using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumpsInTheRoad
{
    class Kata
    {
        public static string Bump(string input)
        {
            int result = input.Count(c => c == 'n');
            if (result > 15) return "Car Dead";
            else return "Woohoo!";
        }
    }
}
