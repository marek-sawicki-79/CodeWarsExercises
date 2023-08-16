using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EasyTimeConvert
{
    public static class Kata
    {
        public static string TimeConvert(int num)
        {
            int hours = num / 60;
            int minutes = num % 60;
            if (num <= 0) return "00:00";
            else
            {
                string minut = minutes.ToString("D2");
                string godz = hours.ToString("D2");
                return $"{godz}:{minut}";
            }
        }
    }
}
