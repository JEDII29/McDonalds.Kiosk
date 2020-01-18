using McDonalds.Kiosk.Utilities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace McDonalds.Kiosk.Utilities.Extensions
{
    public static class OrderExtensions
    {
        public static double GetTotalCost(this IEnumerable<Product> order)
            => order.Sum(product => product.Price);
    }
}
