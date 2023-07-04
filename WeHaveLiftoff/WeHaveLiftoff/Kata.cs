using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeHaveLiftoff
{
    public static class Kata
    {
        public static string Liftoff(List<int> instructions)
        {
            //var sorted = instructions.OrderByDescending(x => x).ToList();
            //return $"{string.Join(" ", sorted)} liftoff!";

            return $"{string.Join(" ", instructions.OrderBy(x => -x))} liftoff!";
        }
    }
}
