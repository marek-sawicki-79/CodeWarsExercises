using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covfefe
{
    public static class Solution
    {
        public static string Covfefe(string tweet)
        {
            //if (!tweet.Contains("coverage")) return $"{tweet} covfefe";
            //else return String.Join(" ", tweet.Split(' ').Select(word => word.Equals("coverage") ? "covfefe" : word));

            return tweet.Contains("coverage") ? tweet.Replace("coverage", "covfefe") : tweet + " covfefe";
        }
    }
}
