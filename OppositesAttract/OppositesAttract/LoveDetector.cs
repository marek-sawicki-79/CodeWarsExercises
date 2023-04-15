using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppositesAttract
{
    public class LoveDetector
    {
        public static bool lovefunc(int flower1, int flower2)
        {
            int flower1Modulo = flower1 % 2;
            int flower2Modulo = flower2 % 2;
            if ((flower1Modulo != 0 && flower2Modulo == 0) || (flower1Modulo == 0 && flower2Modulo != 0))
            {
                return true;
            }
            else return false;
        }
    }
}
