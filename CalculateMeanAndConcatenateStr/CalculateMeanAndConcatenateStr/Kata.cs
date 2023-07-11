using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateMeanAndConcatenateStr
{
    public class Kata
    {
        public static object[] Mean(char[] lst)
        {
            object[] result = new object[2];
            double sum = 0;
            foreach(var item in lst)
            {
                if(char.IsDigit(item))
                {
                    sum += int.Parse(item.ToString());
                }
            }
            result[0] = sum / 10;

            //double avr = lst.Select(n => (int)n).Average();
            //result[0] = avr;
            result[1] = string.Concat(lst.Where(c => !Char.IsDigit(c)).ToArray());
            return result;
        }
    }
}
