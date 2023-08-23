using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnesComplement
{
    public static class Kata
    {
        public static string OnesComplement(string n)
        {
            //string result = n.Replace('0', '2');
            //result = result.Replace('1', '0');
            //result = result.Replace('2', '1');
            //return result;

            return string.Concat(n.Select(x => x == '1' ? '0' : '1'));
        }
    }
}
