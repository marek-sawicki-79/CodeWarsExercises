using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextPalindromicNumber
{
    public class Kata
    {
        public static int NextPal(int val)
        {
            //while(true)
            //{
            //    val ++;
            //    string numberStr = val.ToString();
            //    if (numberStr.SequenceEqual(numberStr.Reverse()))
            //    {
            //        return val;
            //    }
            //}

            do
            {
                val++;
            } while (val.ToString() != string.Concat(val.ToString().Reverse()));
            return val;
        }
    }
}
