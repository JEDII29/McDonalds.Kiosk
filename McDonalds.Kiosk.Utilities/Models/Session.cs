using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime;

namespace McDonalds.Kiosk.Core.Models
{
    public class Session
    {
        public Session()
        {
            SessionId = new Guid();
            SessionId = Guid.NewGuid();
            Order = new Order();
        }

        public Guid SessionId { get; }

        public Order Order { get; }
    }
}
