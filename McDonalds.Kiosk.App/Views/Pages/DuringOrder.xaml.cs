using McDonalds.Kiosk.Core.Models;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace McDonalds.Kiosk.App.Views.Pages
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class DuringOrder : Page
    {

        List<Product> lstProductsInOffer = new List<Product>();
        public DuringOrder()
        {
            InitializeComponent();
        }

        private void LstProduct_Initialized(object sender, EventArgs e)
        {
            //LstProducts.ItemsSource = lstProductsInOffer;
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

        }

        private void GetHotDrinks(object sender, RoutedEventArgs e)
        {

        }
    }
}
