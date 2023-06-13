using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomorphicNumber
{
    class Kata
    {
        public static string Automorphic(int n)
        {
            int squared = n * n;
            int power = n.ToString().Length;
            if (squared % Math.Pow(10, power) == n) return "Automorphic";
            else return "Not!!";
        }
    }
}
