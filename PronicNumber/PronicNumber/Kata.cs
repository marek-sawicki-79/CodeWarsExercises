using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PronicNumber
{
    public class Kata
    {
        public static bool IsPronic(int n)
        {
            int pn = (int)Math.Sqrt(n);
            return pn * (pn + 1) == n;
        }
    }
}
