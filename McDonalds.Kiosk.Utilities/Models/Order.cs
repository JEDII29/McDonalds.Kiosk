using System.Collections.Generic;

namespace McDonalds.Kiosk.Core.Models
{
    public class Order
    {
        public List<int> ProductsIds { get; }

        public Order()
        {
            ProductsIds = new List<int>();
        }
    }
}
