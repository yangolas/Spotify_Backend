using RabbitMQ.Core.Events;
using System;

namespace RabbitMQ.Core.Contracts
{
    public interface IEventHandler<in TEvent> : IEventHandler
        where TEvent : Event
    {
        Task Handle(TEvent @event);
    }

    public interface IEventHandler{}
}