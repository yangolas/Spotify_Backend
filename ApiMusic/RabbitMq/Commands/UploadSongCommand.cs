
using RabbitMQ.Core.Commands;

namespace ApiMusic.RabbitMq.Commands;

public class UploadSongCommand : UploadSongCommandAbstract
{
    public UploadSongCommand(
        string name, 
        string song)
    {
        Name = name;
        Song = song;
    }
}
