using RabbitMQ.Core.Commands;
using RabbitMQ.Core.Events;

namespace RabbitMQ.Core.Contracts;

public interface IEventBus
{
    Task SendCommand<T>(T command) where T : Command;
    void Publish<TEvent>(TEvent @event) where TEvent : Event;
    void Subscribe<TEvent, TEventHandlerType>()
        where TEvent : Event
        where TEventHandlerType : IEventHandler<TEvent>;
}
