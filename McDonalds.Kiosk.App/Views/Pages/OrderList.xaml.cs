using System;
using System.IO;
using System.Windows.Controls;
using McDonalds.Kiosk.Core;
using McDonalds.Kiosk.Core.Contracts;
using McDonalds.Kiosk.Core.Models;
using McDonalds.Kiosk.Core.Extensions;

namespace McDonalds.Kiosk.App.Views.Pages
{
    /// <summary>
    /// Interaction logic for OrderList.xaml
    /// </summary>
    public partial class OrderList : Page
    {
        private readonly SessionKeeper _sessionKeeper;
        private readonly ISessionManager _sessionManager;

        public OrderList(SessionKeeper sessionKeeper, ISessionManager sessionManager)
        {
            InitializeComponent();
            _sessionKeeper = sessionKeeper;
            _sessionManager = sessionManager;
        }

        private void EndAndPay(object sender, System.Windows.RoutedEventArgs e)
        {
            if (_sessionKeeper.Session.Order.Products.Count == 0)
                return;
            using (var file = new StreamWriter("Paragon.txt", true))
            {
                var currentTime = DateTime.Now;

                var combine = $"Zamówienie: nr {_sessionKeeper.Session.SessionId} Data: {currentTime}";
                file.WriteLine(combine);
                foreach (var product in _sessionKeeper.Session.Order.Products)
                {
                    combine = $"{product.Name} cena: {product.Price}";
                    file.WriteLine(combine);
                }
                var TotalCost = _sessionKeeper.Session.Order.Products.GetTotalCost();
                file.WriteLine($"Koszt zamówienia: {TotalCost} ");
                file.WriteLine();
                _sessionManager.Close();

                NavigationService.GoBack();
                NavigationService.GoBack();
            }
        }

        private void GoToShop(object sender, System.Windows.RoutedEventArgs e)
           => NavigationService.GoBack();

        private void LoadOrderList(object sender, System.Windows.RoutedEventArgs e)
        {
            if (_sessionKeeper.Session is null)
                return;

            LstProducts.Items.Clear();

            var productsInOrder = _sessionKeeper.Session.Order.Products;
            productsInOrder.ForEach(x => LstProducts.Items.Add(new Product(x.Id, x.Name, x.Price)));
        }

    }
}
