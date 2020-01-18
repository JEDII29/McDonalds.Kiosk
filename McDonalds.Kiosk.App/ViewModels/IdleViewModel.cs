using McDonalds.Kiosk.App.Commands;
using System.Windows.Input;

namespace McDonalds.Kiosk.App.ViewModels
{
    public class IdleViewModel
    {
        public IdleViewModel(OpenSessionCommand openSessionCommand)
        {
            OpenSessionCommand = openSessionCommand;
        }

        public ICommand OpenSessionCommand { get; }
    }
}
