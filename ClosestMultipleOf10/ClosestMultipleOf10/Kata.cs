using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestMultipleOf10
{
    public class Kata
    {
        public int ClosestMultiple10(int num)
        {
            int down = num;
            int up = num;
            while (down % 10 != 0)
            {
                down--;
            }
            while (up % 10 != 0)
            {
                up++;
            }

            return ((up - num) < (num - down)) ? up : down;
        }
    }
}
