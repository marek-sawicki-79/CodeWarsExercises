using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitsExplosion
{
    public class Digits
    {
        public static string Explode(string s)
        {
            //string result = "";
            //foreach (char c in s)
            //{
            //    string ble = new string(c, int.Parse(c.ToString()));
            //    result = result + ble;
            //}
            //return result;

            //return string.Join("", s.Select(c => new string(c, int.Parse(c.ToString()))));

            return string.Concat(s.Select(n => new String(n, n - 48)));
        }
    }
}
