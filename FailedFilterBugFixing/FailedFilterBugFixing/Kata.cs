using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FailedFilterBugFixing
{
    public class Kata
    {
        public static string FilterNumbers(string str)
        {
            return new string(str.Where(c => !char.IsDigit(c)).ToArray());
        }
    }
}
