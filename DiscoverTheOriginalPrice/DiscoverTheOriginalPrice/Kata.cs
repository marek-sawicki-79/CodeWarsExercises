using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverTheOriginalPrice
{
    public static class Kata
    {
        public static decimal DiscoverOriginalPrice(decimal discountedPrice, decimal salePercentage)
        {
            return Math.Round(discountedPrice / (1 -(salePercentage / 100)), 2);
        }
    }
}
