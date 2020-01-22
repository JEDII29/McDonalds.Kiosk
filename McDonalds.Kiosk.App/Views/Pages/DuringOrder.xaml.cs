using McDonalds.Kiosk.DatabaseContext;
using McDonalds.Kiosk.DatabaseContext.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace McDonalds.Kiosk.App.Views.Pages
{
    public class ProductItem
    {
        public ProductItem(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; }
        public double Price { get; }
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class DuringOrder : Page
    {
        private readonly KioskMySqlContext _dbContext;

        public DuringOrder(KioskMySqlContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private void getBurgers(object sender, RoutedEventArgs e)
        {

        }

        private void GetSides(object sender, RoutedEventArgs e)
        {

        }

        private void GetWraps(object sender, RoutedEventArgs e)
        {

        }

        private void GetColdDrinks(object sender, RoutedEventArgs e)
        {
            var coldDrinks = _dbContext.Drinks.GetColdDrinks().ToList();
            LstProducts.Items.Clear();
            coldDrinks.ForEach(x => LstProducts.Items.Add(new ProductItem(x.Name, x.Price)));
        }

        private void GetHotDrinks(object sender, RoutedEventArgs e)
        {

        }
    }
}
