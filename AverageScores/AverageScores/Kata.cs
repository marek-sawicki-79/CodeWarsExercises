﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageScores
{
    public class Kata
    {
        public static int Average(int[] scores)
        {
            //return (int)Math.Round(scores.Average());
            return Convert.ToInt32(scores.Average());
        }
    }
}
