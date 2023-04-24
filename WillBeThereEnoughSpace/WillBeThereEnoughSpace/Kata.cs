using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillBeThereEnoughSpace
{
    public static class Kata
    {
        public static int Enough(int cap, int on, int wait)
        {
            var result = on + wait - cap;
            return (result > 0) ? result : 0;
        }

    }
}
