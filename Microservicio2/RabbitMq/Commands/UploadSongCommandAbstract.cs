
using RabbitMQ.Core.Commands;

namespace ApiMusic.RabbitMq.Commands;

public class UploadSongCommandAbstract : Command
{
    public string Name;
    public string Song;

}
