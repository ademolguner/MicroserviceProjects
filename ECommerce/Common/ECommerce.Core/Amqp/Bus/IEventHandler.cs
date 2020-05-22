using ECommerce.Core.Amqp.Events;
using ECommerce.Core.Entities;
using System.Threading.Tasks;

namespace ECommerce.Core.Amqp.Bus
{
    public interface IEventHandler<in TEvent> : IEvent where TEvent : Event
    {
        Task Handle(TEvent @event);
    }
}