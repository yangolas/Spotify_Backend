using ApiMusic.RabbitMq.Commands;
using ApiMusic.RabbitMq.Events;
using MediatR;
using RabbitMQ.Core.Contracts;

namespace ApiMusic.RabbitMq.Handlers
{
    public class UploadImageCommandHandler : IRequestHandler<UploadImageCommand, bool>
    {
        private readonly IEventBus _bus;

        public UploadImageCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }
        public Task<bool> Handle(UploadImageCommand request, CancellationToken cancellationToken)
        {
            _bus.Publish(new UploadImageEvent(request.Name, request.Image));

            return Task.FromResult(true);
        }
    }
}
