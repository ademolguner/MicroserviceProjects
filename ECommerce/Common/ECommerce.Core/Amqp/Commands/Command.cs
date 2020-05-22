using ECommerce.Core.Amqp.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Core.Amqp.Commands
{
    public abstract class Command : Message
    {
        public DateTime TimeStamp { get; protected set; }

        protected Command()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
