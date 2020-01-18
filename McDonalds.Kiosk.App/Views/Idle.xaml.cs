using McDonalds.Kiosk.App.ViewModels;
using System.Windows;

namespace McDonalds.Kiosk.App.Views
{
    /// <summary>
    /// Interaction logic for Idle.xaml
    /// </summary>
    public partial class Idle : Window
    {
        public Idle(IdleViewModel idleViewModel)
        {
            InitializeComponent();

            DataContext = idleViewModel;
        }
    }
}
