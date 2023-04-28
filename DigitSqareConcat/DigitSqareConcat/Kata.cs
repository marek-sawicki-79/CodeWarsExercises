using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitSqareConcat
{
    public class Kata
    {
        public static int SquareDigits(int n)
        {
            char[] nArr = n.ToString().ToCharArray();
            int[] cArr = new int[nArr.Length];
            for (int i = 0; i < nArr.Length; i++)
            {
                int no = int.Parse(nArr[i].ToString());
                cArr[i] = (int)Math.Pow(no, 2) ;
            }
            StringBuilder sb = new StringBuilder();
            foreach(int number in cArr) { sb.Append(number.ToString());}
            int result = int.Parse(sb.ToString());
            return result;
        }
    }
}
