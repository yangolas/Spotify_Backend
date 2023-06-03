namespace RabbitMQ.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; set; }
        public Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}