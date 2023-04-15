using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedleInHaystack
{
    public class Kata
    {
        public static string FindNeedle(object[] haystack)
        {
            int result = Array.IndexOf(haystack, "needle");
            return $"found the needle at position {result}";
        }
    }
}
