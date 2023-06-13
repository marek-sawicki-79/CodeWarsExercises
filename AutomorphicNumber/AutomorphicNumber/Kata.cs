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
            if (squared % 10 == n % 10) return "Automorphic";
            else return "Not!!";
        }
    }
}
