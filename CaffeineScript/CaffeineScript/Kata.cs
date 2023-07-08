using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaffeineScript
{
    public class Kata
    {
        public static string CaffeineBuzz(int n)
        {
            //string result = "";
            //if(n % 3 == 0 && n % 4 == 0)
            //{
            //    result = "Coffee";
            //    if(n % 2 ==0)
            //    {
            //        result = $"{result}Script";
            //    }
            //}
            //else if (n % 3 == 0)
            //{
            //    result = "Java";
            //    if (n % 2 == 0)
            //    {
            //        result = $"{result}Script";
            //    }
            //}
            //else
            //{
            //    result = "mocha_missing!";
            //}
            //return result;

            return n % 3 == 0 ? (n % 4 == 0 ? "Coffee" : "Java") + (n % 2 == 0 ? "Script" : "") : "mocha_missing!";
        }
    }
}
