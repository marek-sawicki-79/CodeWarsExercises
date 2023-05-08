using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallEnough_ArrayCheck
{
    public class Kata
    {
        public static bool SmallEnough(int[] a, int limit)
        {
            return a.All(x => x <= limit);
        }
    }
}
