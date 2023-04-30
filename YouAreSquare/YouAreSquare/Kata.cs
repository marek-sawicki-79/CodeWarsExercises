using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouAreSquare
{
    public class Kata
    {
        public static bool IsSquare(int n)
        {
            double sqared = Math.Sqrt(n);
            return (sqared == (int)sqared) ? true : false;
        }
    }
}
