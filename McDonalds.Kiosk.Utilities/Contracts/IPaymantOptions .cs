using System;
using System.Collections.Generic;
using System.Text;

namespace McDonalds.Kiosk.Utilities.Contracts
{
    public interface IPaymantOptions
    {
        void PayByCard(double totalCost);

        void PayByCash(double totalCost);
    }
}
