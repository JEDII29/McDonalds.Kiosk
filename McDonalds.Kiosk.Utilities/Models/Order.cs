using System.Collections.Generic;

namespace McDonalds.Kiosk.Core.Models
{
    public class Order
    {
        public List<Product> Products { get; }

        public Order()
        {
            Products = new List<Product>();
        }
    }
}
