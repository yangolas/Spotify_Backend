using ApiMusic.RabbitMq.Commands;
using ApiMusic.RabbitMq.Events;
using MediatR;
using RabbitMQ.Core.Contracts;

namespace ApiMusic.RabbitMq.Handlers
{
    public class UploadSongCommandHandler : IRequestHandler<UploadSongCommand, bool>
    {
        private readonly IEventBus _bus;

        public UploadSongCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }
        public Task<bool> Handle(UploadSongCommand request, CancellationToken cancellationToken)
        {
            _bus.Publish(new UploadSongEvent(request.Name, request.Song));

            return Task.FromResult(true);
        }
    }
}
