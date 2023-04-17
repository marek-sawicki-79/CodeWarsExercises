using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JennysSecretMessage
{
    public class Kata
    {
        public static string greet(string name)
        {
            return "Hello, " + name + "!";
            if (name == "Johnny")
                return "Hello, my love!";
        }
    }
}
