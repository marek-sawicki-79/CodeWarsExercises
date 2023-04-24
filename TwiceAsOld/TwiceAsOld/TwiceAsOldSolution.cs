using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwiceAsOld
{
    public class TwiceAsOldSolution
    {
        public static int TwiceAsOld(int dadYears, int sonYears)
        {
            var dadOldWhenBirth = dadYears - sonYears;
            uint whenTwiceAsOld = (uint)(2 * dadOldWhenBirth - dadYears);
            int ch = (int)whenTwiceAsOld;
            int result = (int)Math.Sqrt(ch * ch);
            return result;
        }
    }
}
