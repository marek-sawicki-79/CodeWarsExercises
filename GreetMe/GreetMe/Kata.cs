using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetMe
{
    public static class Kata
    {
        public static string Greet(string name)
        {
            name = name.ToLower();
            char bigLetter = char.ToUpper(name[0]);
            string smallLetters = name.Substring(1);
            string properName = bigLetter + smallLetters;
            return $"Hello {properName}!";
        }
    }
}
