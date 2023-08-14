using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvisibleCubes
{
    public class Kata
    {
        public static int NotVisibleCubes(int n)
        {
            return (n <= 2) ? 0 : (int)Math.Pow((n - 2), 3);
        }
    }
}
