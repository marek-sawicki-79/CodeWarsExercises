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
            int hours = 0;
            int minutes = 0;
            string result = "";
            if (num <= 0) return "00:00";
            hours = num / 60;
            minutes = num % 60;
            result = (hours < 10) ? $"0{hours}:{minutes}"
                : (minutes < 10) ? $"{hours}:0{minutes}" : $"{hours}:{minutes}";
            return result;
        }
    }
}
