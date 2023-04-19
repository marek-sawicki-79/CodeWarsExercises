using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoIGetABonus
{
    public static class Kata
    {
        public static string bonus_time(int salary, bool bonus)
        {
            return (bonus == true) ? $"${salary * 10}" : $"${salary}";
        }
    }
}
