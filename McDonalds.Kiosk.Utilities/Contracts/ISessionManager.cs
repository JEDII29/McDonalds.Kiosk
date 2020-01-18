using System;
using System.Collections.Generic;
using System.Text;

namespace McDonalds.Kiosk.Utilities.Contracts
{
    public interface ISessionManager
    {
        void Open();

        void Close();
    }
}
