using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoToOne
{
    public class TwoToOne
    {

        public static string Longest(string s1, string s2)
        {
            //string distinctS1 = new string(s1.Distinct().ToArray());
            //string distinctS2 = new string(s2.Distinct().ToArray());
            //string stringSum = distinctS1 + distinctS2;
            //char[] sorted = stringSum.Distinct().OrderBy(x => x).ToArray();
            //return new string(sorted);

            return new string((s1 + s2).Distinct().OrderBy(x => x).ToArray());
        }
    }
}
