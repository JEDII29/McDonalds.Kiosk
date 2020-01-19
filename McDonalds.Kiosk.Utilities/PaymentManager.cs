using McDonalds.Kiosk.Core.Contracts;
using System;

namespace McDonalds.Kiosk.Core
{
    public class PaymentManager : IPaymantOptions
    {
        public void PayByCard(double totalCost)
            => throw new NotImplementedException();

        public void PayByCash(double totalCost)
            => throw new NotImplementedException();
    }
}
