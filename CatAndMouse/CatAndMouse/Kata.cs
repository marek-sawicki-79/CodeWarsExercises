using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatAndMouse
{
    public class Kata
    {
        public static string CatMouse(string x)
        {
            var mousePosition = x.IndexOf('m');
            var catPosition = x.IndexOf('C');
            return (mousePosition - catPosition > 3) ? "Escaped!" : "Caught!";
        }
    }
}
