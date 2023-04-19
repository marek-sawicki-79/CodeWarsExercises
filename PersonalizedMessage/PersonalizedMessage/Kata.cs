using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalizedMessage
{
    public class Kata
    {
        public static string Greet(string name, string owner)
        {
            return (name == owner) ? "Hello boss" : "Hello guest";
        }
    }
}
