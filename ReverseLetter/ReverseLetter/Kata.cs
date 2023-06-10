using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLetter
{
    public class Kata
    {
        public string ReverseLetter(string str)
        {
            char[] jinx = str.ToCharArray();
            Array.Reverse(jinx);
            return new string(jinx.Where(c => char.IsLetter(c)).ToArray());
        }
    }
}
