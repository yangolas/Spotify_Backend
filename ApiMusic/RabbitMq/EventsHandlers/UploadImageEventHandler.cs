using ApiMusic.Models;
using ApiMusic.RabbitMq.Events;
using Microsoft.Extensions.Options;
using RabbitMQ.Core.Contracts;

namespace ApiMusic.RabbitMq.EventsHandlers
{
    public class UploadImageEventHandler : IEventHandler<UploadImageEvent>
    {
        private readonly UploadSettings _uploadSettings;

        public UploadImageEventHandler(IOptions<UploadSettings> uploadSettings)
        {
            _uploadSettings = uploadSettings.Value;
        }

        public Task Handle(UploadImageEvent @event)
        {
            byte[] imageByte = Convert.FromBase64String(@event.Image);

            string folderPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                _uploadSettings.PathImages
            );

            string filePath = Path.Combine(
                folderPath,
                @event.Name
            );

            File.WriteAllBytes(
                filePath,
                imageByte
            );

            return Task.CompletedTask;
        }
    }
}
