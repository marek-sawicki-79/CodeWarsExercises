using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayByLength
{
    public class Kata
    {
        public static string[] SortByLength(string[] array)
        {
            Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));
            return array;
        }
    }
}
