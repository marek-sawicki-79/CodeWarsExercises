using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsDivisibleByXAndY
{
    public class DivisibleNb
    {
        public static bool IsDivisible(int n, int x, int y)
        {
            var nByX = n % x;
            var nByY = n % y;
            if (nByX == 0 && nByY == 0)
            {
                return true;
            }
            else return false;
        }
    }
}
