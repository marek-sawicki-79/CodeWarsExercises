using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnesAndZeros
{
    class Kata
    {
        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            //int result = 0;
            //int powerOf2 = BinaryArray.Length - 1;
            //foreach(int bit in BinaryArray)
            //{
            //    result += bit * (int)Math.Pow(2, powerOf2);
            //    powerOf2--;
            //}
            //return result;
            return Convert.ToInt32(string.Join("", BinaryArray), 2);
        }
    }
}
