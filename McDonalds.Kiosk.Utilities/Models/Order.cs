using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using McDonalds.Kiosk.Utilities.Contracts;
using McDonalds.Kiosk.Utilities.Models;

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
