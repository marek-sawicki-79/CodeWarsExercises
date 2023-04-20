using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetAlarm
{
    public class Kata
    {
        public static bool SetAlarm(bool employed, bool vacation)
        {
            return (employed == true && vacation == false) ? true : false;
        }
    }
}
