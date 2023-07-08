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
            string result = "";
            if(n % 3 == 0 && n % 4 == 0)
            {
                result = "Coffee";
            }
            else if (n % 3 == 0)
            {
                result = "Java";
            }
            else
            {
                result = "mocha_missing!";
            }

            if(n % 2 == 0)
            {
                result = $"{result}Script";
            }
            return result;
        }
    }
}
