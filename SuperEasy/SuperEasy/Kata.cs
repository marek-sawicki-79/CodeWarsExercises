using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperEasy
{
    public class Kata
    {
        public static string Problem(String a)
        {
            if (double.TryParse(a, NumberStyles.Any, CultureInfo.InvariantCulture, out double result))
            {
                double realResult = result * 50 + 6;
                int end = (int)realResult;
                return end.ToString();
            }
            else return "Error";
        }
    }
}
