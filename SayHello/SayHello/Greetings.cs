﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayHello
{
    public class Greetings
    {
        public static string greet(string name)
        {
            if (string.IsNullOrEmpty(name)) return null;
            else return $"hello {name}!";
        }
    }
}
