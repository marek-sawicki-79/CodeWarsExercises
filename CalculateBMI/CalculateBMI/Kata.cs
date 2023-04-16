using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateBMI
{
    public class Kata
    {
        public static string Bmi(double weight, double height) => (weight = weight / height / height) > 30 ? "Obese" : weight > 25 ? "Overweight" : weight > 18.5 ? "Normal" : "Underweight";
        //{
        //    //double bmi = weight / (height * height);
        //    //if (bmi <= 18.5) return "Underweight";
        //    //else if (bmi > 18.5 && bmi <= 25.0) return "Normal";
        //    //else if (bmi > 25.0 && bmi <= 30.0) return "Overweight";
        //    //else return "Obese";


        //}
    }
}
