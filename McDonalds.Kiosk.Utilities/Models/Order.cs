using System.Collections.Generic;

namespace McDonalds.Kiosk.Utilities.Models
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
