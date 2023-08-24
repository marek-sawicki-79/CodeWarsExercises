using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyStringsInArray
{
    public static class Kata
    {
        public static string ArrMultiply(string[] arr)
        {
            //int result = 0;
            //int doop = int.Parse(arr[0]);
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    result = doop * int.Parse(arr[i]);
            //    doop = result;
            //}
            //return result.ToString();

            return arr.Aggregate((a, b) => $"{int.Parse(a) * int.Parse(b)}");
        }
    }
}
