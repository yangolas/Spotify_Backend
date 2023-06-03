using RabbitMQ.Core.Commands;

namespace ApiMusic.RabbitMq.Commands;

public class UploadImageCommandAbstract : Command
{
    public string Name;
    public string Image;

}
