using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOficceVI_Sabbatical
{
    public class Kata
    {
        public static string Sabb(string s, int val, int happiness)
        {
            string witch = "sabbatical";
            int sabbSum = s.Count(c => witch.Contains(c));
            int verdict = val + happiness + sabbSum;
            return (verdict > 22) ? "Sabbatical! Boom!" : "Back to your desk, boy.";
        }
    }
}
