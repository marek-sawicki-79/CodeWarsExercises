using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixStringCase
{
    class Kata
    {
        public static string Solve(string s)
        {
            int upperCaseCount = 0;
            int lowerCaseCount = 0;
            foreach(char c in s)
            {
                if (char.IsUpper(c))
                {
                    upperCaseCount++;
                }
                else lowerCaseCount++;
            }
            if (upperCaseCount > lowerCaseCount) return s.ToUpper();
            else return s.ToLower();
        }
    }
}
