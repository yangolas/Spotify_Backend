using RabbitMQ.Core.Commands;
using RabbitMQ.Core.Events;

namespace ApiMusic.RabbitMq.Events;

public class UploadSongEvent : Event
{
    public string Name { get; set; }
    public string Song { get; set; }
    public UploadSongEvent(
        string name,
        string song)
    {
        Name = name;
        Song = song;
    }
}
