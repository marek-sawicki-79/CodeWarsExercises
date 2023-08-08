using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElapsedSeconds
{
    public class Kata
    {
        public static int ElapsedSeconds(DateTime startDate, DateTime endDate)
        {
            return (int)(endDate - startDate).TotalSeconds;
        }
    }
}
