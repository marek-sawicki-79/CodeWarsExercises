﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentFinalGrade
{
    public class Kata
    {
        public static int FinalGrade(int exam, int projects)
        {
            if (exam > 90 || projects > 10) return 100;
            else if (exam > 70 && projects >= 5) return 90;
            else if (exam > 50 && projects >= 2) return 75;
            else return 0;

        }
    }
}
