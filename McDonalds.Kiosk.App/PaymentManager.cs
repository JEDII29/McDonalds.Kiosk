using System;
using System.Collections.Generic;
using System.Text;
using McDonalds.Kiosk.Utilities.Contracts;

namespace McDonalds.Kiosk.App
{
    public class PaymentManager : IPaymantOptions
    {
        public void PayByCard(double totalCost) 
            => throw new NotImplementedException();

        public void PayByCash(double totalCost) 
            => throw new NotImplementedException();
    }
}
