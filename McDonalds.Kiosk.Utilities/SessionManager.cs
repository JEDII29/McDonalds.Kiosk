using McDonalds.Kiosk.Core.Contracts;
using McDonalds.Kiosk.Core.Models;

namespace McDonalds.Kiosk.Core
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
