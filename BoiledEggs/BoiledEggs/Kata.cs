﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoiledEggs
{
    public class Kata
    {
        public static int CookingTime(int eggs)
        {
            return (int)Math.Ceiling(eggs / 8.0) * 5;
        }
    }
}
