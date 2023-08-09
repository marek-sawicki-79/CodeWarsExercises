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
            string witch = "SABTICLsabticl";
            int sabbSum = witch.Sum(c => s.Count(x => x == c));
            int verdict = val + happiness + sabbSum;
            return verdict > 22 ? "Sabbatical! Boom!" : "Back to your desk, boy.";
        }
    }
}
