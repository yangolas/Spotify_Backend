using ApiMusic.Models;
using ApiMusic.RabbitMq.Events;
using Microsoft.Extensions.Options;
using RabbitMQ.Core.Contracts;

namespace ApiMusic.RabbitMq.EventsHandlers;

public class UploadSongEventHandler : IEventHandler<UploadSongEvent>
{
    private readonly UploadSettings _uploadSettings;

    public UploadSongEventHandler(IOptions<UploadSettings> uploadSettings)
    {
        _uploadSettings = uploadSettings.Value;
    }

    public Task Handle(UploadSongEvent @event)
    {
        byte[] songBytes = Convert.FromBase64String(@event.Song);

        string folderPath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            _uploadSettings.PathSongs
        );

        string filePath = Path.Combine(
            folderPath, 
            @event.Name
        );

        File.WriteAllBytes(
            filePath, 
            songBytes
        );

        return Task.CompletedTask;
    }
}
