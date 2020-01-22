using McDonalds.Kiosk.App.ViewModels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace McDonalds.Kiosk.App.Views
{
    /// <summary>
    /// Interaction logic for Idle.xaml
    /// </summary>
    public partial class Idle : Window
    {
        private readonly MainWindow _mainWindow;

        public Idle(IdleViewModel idleViewModel)
        {
            InitializeComponent();

            DataContext = idleViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.NavigationService.Navigate(_mainWindow);
            
        }
    }
}
