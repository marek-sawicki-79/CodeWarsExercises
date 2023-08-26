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
            int num = 0;
            int? nullableNum = n as int?;

            if (nullableNum == null)
            {
                return false;
            }
            else
            {
                num = nullableNum.Value;
            }
            if (num <= 0) return false;
            while(num > 1)
            {
                if(num % 4 != 0)
                {
                    return false;
                }
                num /= 4;
            }

            return true;
        }
    }
}
