using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isograms
{
    public class Kata
    {
        public static bool IsIsogram(string str)
        {
            return str.ToLower().GroupBy(c => c).All(l => l.Count() == 1);
        }
    }
}
