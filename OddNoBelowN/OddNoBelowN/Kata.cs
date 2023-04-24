using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNoBelowN
{
    public static class Kata
    {
        public static ulong OddCount(ulong n)
        {
        //    ulong[] result = new [];
        //    for (ulong i = 0; i < n; i++)
        //    {
        //        if (i % 2 != 0) result.Add(i);
        //    }
        //    return (ulong)result.Count();
        //}

        if (n % 2 == 0)
        {
            return n / 2;
        }
        else
        {
            return (n -1) / 2;
        }
    }
}
}
