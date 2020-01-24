using McDonalds.Kiosk.Core;
using McDonalds.Kiosk.Core.Contracts;
using McDonalds.Kiosk.Core.Models;
using McDonalds.Kiosk.DatabaseContext;
using McDonalds.Kiosk.DatabaseContext.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using McDonalds.Kiosk.Core.Extensions;
using McDonalds.Kiosk.DatabaseContext.Entities;
using System;

namespace McDonalds.Kiosk.App.Views.Pages
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class DuringOrder : Page
    {
        private readonly KioskMySqlContext _dbContext;
        private readonly SessionKeeper _sessionKeeper;
        private readonly ISessionManager _sessionManager;
        private readonly OrderList _orderlist;

        public DuringOrder(
            KioskMySqlContext dbContext,
            SessionKeeper sessionKeeper,
            ISessionManager sessionManager,
            OrderList orderListView)
        {
            _dbContext = dbContext;
            _sessionManager = sessionManager;
            _orderlist = orderListView;
            _sessionKeeper = sessionKeeper;

            InitializeComponent();
        }

        private void GetBurgers(object sender, RoutedEventArgs e)
        {
            var burgers = _dbContext.Food.GetBurgers().ToList();
            LstProducts.Items.Clear();
            burgers.ForEach(x => LstProducts.Items.Add(new Product(x.Id, x.Name, x.Price)));
        }

        private void GetSides(object sender, RoutedEventArgs e)
        {
            var sides = _dbContext.Food.GetSides().ToList();
            LstProducts.Items.Clear();
            sides.ForEach(x => LstProducts.Items.Add(new Product(x.Id, x.Name, x.Price)));
        }

        private void GetWraps(object sender, RoutedEventArgs e)
        {
            var wraps = _dbContext.Food.GetWraps().ToList();
            LstProducts.Items.Clear();
            wraps.ForEach(x => LstProducts.Items.Add(new Product(x.Id, x.Name, x.Price)));
        }

        private void GetColdDrinks(object sender, RoutedEventArgs e)
        {
            var coldDrinks = _dbContext.Drinks.GetColdDrinks().ToList();
            LstProducts.Items.Clear();
            coldDrinks.ForEach(x => LstProducts.Items.Add(new Product(x.Id, x.Name, x.Price)));
        }

        private void GetHotDrinks(object sender, RoutedEventArgs e)
        {
            var hotDrinks = _dbContext.Drinks.GetHotDrinks().ToList();
            LstProducts.Items.Clear();
            hotDrinks.ForEach(x => LstProducts.Items.Add(new Product(x.Id, x.Name, x.Price)));
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            _sessionManager.Close();
            NavigationService.GoBack();
        }

        private void GoToCart(object sender, RoutedEventArgs e)
            => NavigationService.Navigate(_orderlist);


        private void AddProductToOrder(object sender, RoutedEventArgs e)
        {
            var selectedProduct = (Product)LstProducts.SelectedItem;
            if (selectedProduct is null)
                return;

            var products = _sessionKeeper.Session.Order.Products;
            products.Add(selectedProduct);

            TotalCost.Text = products.GetTotalCost().ToString();
        }

        private void TotalCost_Initialized(object sender, System.EventArgs e)
            => TotalCost.Text = "0";


    }
}
