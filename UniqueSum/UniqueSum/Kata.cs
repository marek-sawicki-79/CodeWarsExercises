using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueSum
{
    public static class Kata
    {
        public static int? UniqueSum(List<int> lst)
        {
            List<int> distinctInts = lst.Distinct().ToList();
            int result = distinctInts.Sum();
            if (lst == null || result == 0) return null;
            else return result;
        }
    }
}
