using System;
using System.Collections.Generic;
using System.Text;

namespace McDonalds.Kiosk.Utilities.Models
{
    public abstract class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
