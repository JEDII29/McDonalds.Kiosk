using McDonalds.Kiosk.Core.Contracts;
using System;
using System.Windows.Input;

namespace McDonalds.Kiosk.App.Commands
{
    public class OpenSessionCommand : ICommand
    {
        private readonly ISessionManager _sessionManager;

        public OpenSessionCommand(ISessionManager sessionManager)
        {
            _sessionManager = sessionManager;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
            => true;

        public void Execute(object parameter)
            => _sessionManager.Open();
    }
}
