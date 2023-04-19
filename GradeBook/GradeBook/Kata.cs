using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class Kata
    {
        public static char GetGrade(int s1, int s2, int s3)
        {
            double av = (s1 + s2 + s3) / 3;
            return (av >= 90) ? 'A' : (av >= 80) ? 'B' : (av >= 70) ? 'C' : (av >= 60) ? 'D' : 'F';
        }
    }
}
