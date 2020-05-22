using ECommerce.Core.Amqp.Events;
using System;

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