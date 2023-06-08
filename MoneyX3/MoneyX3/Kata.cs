using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyX3
{
    public class Kata
    {
        public static int CalculateYears(double principal, double interest, double tax, double desiredPrincipal)
        {
            int years = 0;
            while(principal < desiredPrincipal)
            {
                principal = principal + (principal * interest) - (principal * interest * tax);
                years++;
            }
            return years;
        }
    }
}
