using RabbitMQ.Core.Commands;

namespace ApiMusic.RabbitMq.Commands;

public class UploadImageCommand : UploadImageCommandAbstract
{
    public UploadImageCommand(
        string name,
        string image)
    {
        Name = name;
        Image = image;
    }
}
