using ApiMusic.Models;
using ApiMusic.RabbitMq.Events;
using Microsoft.Extensions.Options;
using RabbitMQ.Core.Contracts;
using System;

namespace ApiMusic.RabbitMq.EventsHandlers
{
    public class UploadImageEventHandler : IEventHandler<UploadImageEvent>
    {
        private readonly UploadSettings _uploadSettings;
        private readonly IWebHostEnvironment _environment;

        public UploadImageEventHandler(
            IOptions<UploadSettings> uploadSettings,
            IWebHostEnvironment environment
            )
        {
            _uploadSettings = uploadSettings.Value;
            _environment = environment;
        }

        public Task Handle(UploadImageEvent @event)
        {
            byte[] imageByte = Convert.FromBase64String(@event.Image);

            string filePath = Path.Combine(
             _environment.ContentRootPath,
             _uploadSettings.PathImages,
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
