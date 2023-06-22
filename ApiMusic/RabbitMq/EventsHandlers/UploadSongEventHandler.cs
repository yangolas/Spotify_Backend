using ApiMusic.Models;
using ApiMusic.RabbitMq.Events;
using Microsoft.Extensions.Options;
using RabbitMQ.Core.Contracts;

namespace ApiMusic.RabbitMq.EventsHandlers;

public class UploadSongEventHandler : IEventHandler<UploadSongEvent>
{
    private readonly UploadSettings _uploadSettings;
    private readonly IWebHostEnvironment _environment;

    public UploadSongEventHandler(
        IOptions<UploadSettings> uploadSettings,
        IWebHostEnvironment environment
        )
    {
        _uploadSettings = uploadSettings.Value;
        _environment = environment;
    }

    public Task Handle(UploadSongEvent @event)
    {
        byte[] songBytes = Convert.FromBase64String(@event.Song);

        string filePath = Path.Combine(
            _environment.ContentRootPath,
            _uploadSettings.PathSongs,
            @event.Name
        );

        File.WriteAllBytes(
            filePath, 
            songBytes
        );

        return Task.CompletedTask;
    }
}
