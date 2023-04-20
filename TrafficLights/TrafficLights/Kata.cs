using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLights
{
    public class Kata
    {
        public static string UpdateLight(string current)
        {
            return (current == "green") ? "yellow" : (current == "yellow") ? "red" : (current == "red") ? "green" :null;
        }
    }
}
