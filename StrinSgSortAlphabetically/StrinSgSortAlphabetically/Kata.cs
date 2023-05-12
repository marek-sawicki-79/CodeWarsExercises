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
            return new string(code.OrderBy(x => x.ToString()).ToArray());
        }
    }
}
