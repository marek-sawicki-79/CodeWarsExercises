using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTheMeanOfAnArray
{
    public class Kata
    {
        public static int GetAverage(int[] marks)
        {
            return (int)Math.Floor(marks.Average());
        }
    }
}
