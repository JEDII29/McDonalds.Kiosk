using System;
using System.Collections.Generic;
using System.Text;
using McDonalds.Kiosk.Utilities.Contracts;
using McDonalds.Kiosk.Utilities.Models;

namespace McDonalds.Kiosk.App
{
    public class SessionManager : ISessionManager
    {
        private readonly SessionKeeper _session;

        public SessionManager(SessionKeeper session)
        {
            _session = session;
        }

        //TODO: add logs
        public void Open()
            => _session.Session = new Session();

        //TODO: add logs
        public void Close()
            => _session.Session = null;
    }
}
