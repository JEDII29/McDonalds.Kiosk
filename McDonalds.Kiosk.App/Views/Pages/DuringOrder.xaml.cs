using McDonalds.Kiosk.Core;
using McDonalds.Kiosk.Core.Contracts;
using McDonalds.Kiosk.Core.Models;
using McDonalds.Kiosk.DatabaseContext;
using McDonalds.Kiosk.DatabaseContext.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace McDonalds.Kiosk.App.Views.Pages
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class DuringOrder : Page
    {
        private readonly KioskMySqlContext _dbContext;
        private readonly ISessionManager _sessionManager;
        private readonly OrderList _orderlist;
        private readonly SessionKeeper _sessionKeeper;
        


        public DuringOrder(KioskMySqlContext dbContext, ISessionManager sessionManager, OrderList orderList, SessionKeeper sessionKeeper)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _sessionManager = sessionManager;
            _orderlist = orderList;
            _sessionKeeper = sessionKeeper;
        }

        private void getBurgers(object sender, RoutedEventArgs e)
        {
            var burgers = _dbContext.Food.GetBurgers().ToList();
            LstProducts.Items.Clear();
            burgers.ForEach(x => LstProducts.Items.Add(new { x.Name, x.Price }));
        }

        private void GetSides(object sender, RoutedEventArgs e)
        {
            var sides = _dbContext.Food.GetSides().ToList();
            LstProducts.Items.Clear();
            sides.ForEach(x => LstProducts.Items.Add(new { x.Name, x.Price }));
        }

        private void GetWraps(object sender, RoutedEventArgs e)
        {
            var wraps = _dbContext.Food.GetWraps().ToList();
            LstProducts.Items.Clear();
            wraps.ForEach(x => LstProducts.Items.Add(new { x.Name, x.Price }));
        }

        private void GetColdDrinks(object sender, RoutedEventArgs e)
        {
            var coldDrinks = _dbContext.Drinks.GetColdDrinks().ToList();
            LstProducts.Items.Clear();
            coldDrinks.ForEach(x => LstProducts.Items.Add(new { x.Name, x.Price }));
        }

        private void GetHotDrinks(object sender, RoutedEventArgs e)
        {
            var hotDrinks = _dbContext.Drinks.GetHotDrinks().ToList();
            LstProducts.Items.Clear();
            hotDrinks.ForEach(x => LstProducts.Items.Add(new { x.Name, x.Price }));
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            _sessionManager.Close();
            this.NavigationService.GoBack();
        }

        private void GoToCart(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(_orderlist);
        }


        private void Add(object sender, RoutedEventArgs e)
        {
            //   var a = (((IEnumerable<Food>)this.LstProducts.SelectedItem.ToString.).ToList());
            //Food a = new Food()
            //    a.Name = LstProducts.SelectedItem.
            //LstProducts.SelectedItem

           // _sessionKeeper.Session.Order.Products.AddRange
        }
    }
}
