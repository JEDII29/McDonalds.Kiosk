using McDonalds.Kiosk.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace McDonalds.Kiosk.Core.Extensions
{
    public static class OrderExtensions
    {
        public static double GetTotalCost(this IEnumerable<Product> order)
            => order.Sum(product => product.Price);
    }
}
