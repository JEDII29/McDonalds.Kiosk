using System;
using System.Collections.Generic;
using System.Text;

namespace McDonalds.Kiosk.Core.Models
{
    public class Session
    {
        public Session()
        {
            SessionId = new Guid();
            Order = new Order();
        }

        public Guid SessionId { get; }

        public Order Order { get; }
    }
}
