

using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using RabbitMQ.Core.Contracts;
using RabbitMQ.Infrastructure.Bus;
using System.Reflection;

namespace RabbitMQ.Infrastructure.Ioc;

public static class DependencyContainer
{
    public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
    {

        //MediatR Mediator
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        //Domain Bus
        services.AddSingleton<IEventBus, RabbitMQBus>(sp =>
        {
            var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
            var optionsFactory = sp.GetService<IOptions<RabbitMQSettings>>();

            return new RabbitMQBus(
                sp.GetService<IMediator>(), 
                scopeFactory, 
                optionsFactory
            );
        });

        return services;
    }
}
