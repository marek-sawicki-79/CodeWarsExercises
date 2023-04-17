using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsHeGonnaSurvive
{
    public class Kata
    {
        public static bool Hero(int bullets, int dragons)
        {
            if (bullets >= 2 * dragons)
            {
                return true;
            }
            else
                return false;
        }
    }
}
