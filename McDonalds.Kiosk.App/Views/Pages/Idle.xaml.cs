using McDonalds.Kiosk.Core.Contracts;
using System.Windows.Controls;

namespace McDonalds.Kiosk.App.Views.Pages
{
    public partial class Idle : Page
    {
        private readonly DuringOrder _duringOrder;
        private readonly ISessionManager _sessionManager;

        public Idle(ISessionManager sessionManager, DuringOrder duringOrder)
        {
            _sessionManager = sessionManager;
            _duringOrder = duringOrder;

            InitializeComponent();
        }

        private void OpenSession_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            _sessionManager.Open();
            NavigationService.Navigate(_duringOrder);
        }
    }
}
