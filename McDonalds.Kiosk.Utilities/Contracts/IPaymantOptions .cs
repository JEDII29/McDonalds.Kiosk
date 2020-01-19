namespace McDonalds.Kiosk.Core.Contracts
{
    public interface IPaymantOptions
    {
        void PayByCard(double totalCost);

        void PayByCash(double totalCost);
    }
}
