﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopBugFix
{
    public class Kata
    {
        public static List<int> CreateList(int number)
        {
            List<int> list = new List<int>();

            for (int counter = 1; counter <= number; counter++)
            {
                list.Add(counter);
            }

            return list;
        }
    }
}
