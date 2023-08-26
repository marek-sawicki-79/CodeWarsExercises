using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowersOf4
{
    public class Power
    {
        public static bool PowerOf4(object n)
        {
            //int num = 0;
            //int? nullableNum = n as int?;

            //if (nullableNum == null)
            //{
            //    return false;
            //}
            //else
            //{
            //    num = nullableNum.Value;
            //}
            //if (num <= 0) return false;
            //while(num > 1)
            //{
            //    if(num % 4 != 0)
            //    {
            //        return false;
            //    }
            //    num /= 4;
            //}

            //return true;

            //if (n is int intValue)
            //{
            //    return intValue > 0 && (intValue & (intValue - 1)) == 0 && (intValue & 0xAAAAAAAA) == 0;
            //}

            //return false;

            return (n is long || n is int) && Convert.ToInt64(n) > 1 && Math.Log(Convert.ToInt64(n), 4) % 1 == 0;
        }
    }
}
