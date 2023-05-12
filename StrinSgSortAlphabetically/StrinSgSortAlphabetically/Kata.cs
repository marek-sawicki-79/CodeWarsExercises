using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrinSgSortAlphabetically
{
    public class Kata
    {
        public static string SortGiftCode(string code)
        {
            var sorted = code.OrderBy(x => x);
            return new string(sorted.ToArray());
        }
    }
}
