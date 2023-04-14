using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingSheep
{
    public class Kata
    {
        public static int CountSheeps(bool[] sheeps)
        {
            return sheeps.Where(s => s).Count();
        }
    }
}
