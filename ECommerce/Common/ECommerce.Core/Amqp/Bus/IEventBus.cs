using ECommerce.Core.Amqp.Commands;
using ECommerce.Core.Amqp.Events;
using System.Threading.Tasks;

namespace ECommerce.Core.Amqp.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;

        void Publish<T>(T @event) where T : Event;

        void Subscribe<T, TH>() where T : Event where TH : IEventHandler<T>;
    }
}