using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TidyNumber
{
    class Kata
    {
        public static bool TidyNumber(int n) => $"{n}" == String.Concat($"{n}".OrderBy(x => x));
        //{
            //char[] digits = n.ToString().ToCharArray();
            //int[] numbers = new int[digits.Length];
            //for(int i = 0; i < digits.Length; i++)
            //{
            //    numbers[i] = int.Parse(digits[i].ToString());
            //}
            //bool result = false;
            //for (int j = 1; j < numbers.Length; j++)
            //{
            //    if (numbers[j] >= numbers[j - 1]) result = true;
            //    else
            //    {
            //        result = false;
            //        break;
            //    }
            //}
            //return result;
        //}
    }
}
