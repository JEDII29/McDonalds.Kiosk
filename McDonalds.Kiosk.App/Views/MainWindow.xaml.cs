using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using McDonalds.Kiosk.Core.Models;
using McDonalds.Kiosk.DatabaseContext.Extensions;

namespace McDonalds.Kiosk.App.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Page
    {
        
        List<Product> lstProductsInOffer = new List<Product>();
        public MainWindow()
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
