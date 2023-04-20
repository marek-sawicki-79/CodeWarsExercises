using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFirstNonConsecutiveNumber
{
    public class Kata
    {
        public static object FirstNonConsecutive(int[] arr)
        {
            int nonConsec = 0;
            string forNull = "";
            for(int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i + 1] - arr[i] != 1)
                {
                    nonConsec = arr[i + 1];
                }
                else forNull = null;
            }
            return (nonConsec != 0) ? nonConsec : forNull;
        }
    }
}
