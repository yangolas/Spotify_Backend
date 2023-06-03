using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ.Core.Commands;
using RabbitMQ.Core.Contracts;
using RabbitMQ.Core.Events;
using System.Text;
using System.Text.Json;

namespace RabbitMQ.Infrastructure.Bus;

public class RabbitMQBus : IEventBus
{
    private readonly RabbitMQSettings _rabbitMQSettings;
    private readonly Dictionary<string, List<Type>> _handlers;
    private readonly List<Type> _eventTypes;
    private readonly IMediator _mediator;
    private readonly IServiceScopeFactory _serviceScopeFactory;
    public RabbitMQBus(
        IMediator mediator, 
        IServiceScopeFactory serviceScopeFactory, 
        IOptions<RabbitMQSettings> rabbitMQSettings)
    {
        _rabbitMQSettings = rabbitMQSettings.Value;
        _handlers = new Dictionary<string, List<Type>>();
        _eventTypes = new List<Type>();
        _mediator = mediator;
        _serviceScopeFactory = serviceScopeFactory;
    }

    public void Publish<TEvent>(TEvent @event) where TEvent : Event
    {
        ConnectionFactory connectionFactory = new()
        {
            HostName = _rabbitMQSettings.Hostname,
            UserName = _rabbitMQSettings.Username,
            Password = _rabbitMQSettings.Password,
            Port = _rabbitMQSettings.Port,
        };

        using (var connection = connectionFactory.CreateConnection())
        using (var channel = connection.CreateModel()) 
        {
            string queueName = @event.GetType().Name;

            channel.QueueDeclare(
                queueName,
                false,
                false,
                false,
                null
            );
            string message = JsonSerializer.Serialize(@event);
            byte[] body = Encoding.UTF8.GetBytes(message);

            channel.BasicPublish(
                "",
                queueName,
                null,
                body
            );
        }
    }

    public Task SendCommand<T>(T command) where T : Command
    {
        return _mediator.Send(command);
    }

    public void Subscribe<TEvent, TEventHandlerType>()
        where TEvent : Event
        where TEventHandlerType : IEventHandler<TEvent>
    {
        var eventName = typeof(TEvent).Name;
        var handlerType = typeof(TEventHandlerType);

        if (!_eventTypes.Contains(typeof(TEvent)))
        {
            _eventTypes.Add(typeof(TEvent));
        }

        if (!_handlers.ContainsKey(eventName))
        {
            _handlers.Add(eventName, new List<Type>());
        }

        if (_handlers[eventName].Any(s => s.GetType() == handlerType))
        {
            throw new ArgumentException($"El handler exception {handlerType.Name} ya fue registrado anteriormente por '{eventName}'", nameof(handlerType));
        }

        _handlers[eventName].Add(handlerType);

        Consume<TEvent>();
    }

    private void Consume<TEvent>() where TEvent : Event
    {
        try
        {

            ConnectionFactory connectionFactory = new()
            {
                HostName = _rabbitMQSettings.Hostname,
                UserName = _rabbitMQSettings.Username,
                Password = _rabbitMQSettings.Password,
                Port = _rabbitMQSettings.Port,
                DispatchConsumersAsync = true
            };

            string queueName = typeof(TEvent).Name;

            var connection = connectionFactory.CreateConnection();
            var channel = connection.CreateModel();
            
            channel.QueueDeclare(
                queueName,
                false,
                false,
                false,
                null
            );

            var consumer = new AsyncEventingBasicConsumer(channel);

            consumer.Received += OnReceived;

            channel.BasicConsume(queueName, true, consumer);
            
        }
        catch (Exception ex) 
        {
            var message = ex.Message;
        }
    }

    private async Task OnReceived(object sender, BasicDeliverEventArgs @event)
    {
        var eventName = @event.RoutingKey;
        var message = Encoding.UTF8.GetString(@event.Body.Span);

        try
        {
            await ProcessEvent(eventName, message).ConfigureAwait(false);
        }
        catch (Exception ex)
        {

        }
    }

    private async Task ProcessEvent(string eventName, string message)
    {
        if (_handlers.ContainsKey(eventName))
        {
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                var subscriptions = _handlers[eventName];

                foreach (var subscription in subscriptions)
                {
                    var handler = scope.ServiceProvider.GetService(subscription);  
                    if (handler == null) continue;
                    var eventType = _eventTypes.SingleOrDefault(t => t.Name == eventName);
                    var @event = JsonSerializer.Deserialize(message, eventType);
                    var concreteType = typeof(IEventHandler<>).MakeGenericType(eventType);

                    await (Task)concreteType.GetMethod("Handle").Invoke(handler, new object[] { @event });

                }

            }
        }

    }

}
