using McDonalds.Kiosk.Utilities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace McDonalds.Kiosk.Utilities.Models
{
    public abstract class Drink : Product
    {
        public double Amount { get; set; }
    }
}
