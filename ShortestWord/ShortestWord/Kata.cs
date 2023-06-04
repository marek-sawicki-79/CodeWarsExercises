using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestWord
{
    public class Kata
    {
        public static int FindShort(string s)
        {
            //string[] sSplit = s.Split(' ');
            //return sSplit.Min(s => s.Length);
            return s.Split(' ').Min(s => s.Length);
        }
    }
}
