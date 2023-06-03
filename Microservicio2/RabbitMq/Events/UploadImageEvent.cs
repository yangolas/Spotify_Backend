using RabbitMQ.Core.Events;

namespace ApiMusic.RabbitMq.Events;

public class UploadImageEvent:Event
{
    public string Name { get; set; }
    public string Image { get; set; }

    public UploadImageEvent(
        string name,
        string image)
    {
        Name = name;
        Image = image;
    }
}
