using MediatR;

namespace RabbitMQ.Core.Commands
{
    public abstract class Message : IRequest<bool>
    {
        public string MessageType { get; set; }

        protected Message()
        {
            MessageType = GetType().Name;
        }
    }
}