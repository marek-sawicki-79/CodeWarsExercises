using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCouponCode
{ 
public static class Kata
    {
        public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate)
        {
            DateTime today;
            DateTime expirationDay;
            DateTime.TryParseExact(currentDate, "MMMM d, yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out today);
            DateTime.TryParseExact(expirationDate, "MMMM d, yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out expirationDay);
            if (enteredCode != correctCode || today > expirationDay) return false;
            else return true;
        }
    }
}
