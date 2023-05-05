using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingChocolate
{
    public class Kata
    {
        public static int BreakChocolate(int n, int m)
        {
            if (n <= 1 && m <= 1) return 0;
            else return (n - 1) + n * (m - 1);
        }
    }
}
