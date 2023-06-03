

using ApiMusic.Models;
using ApiMusic.RabbitMq.Events;
using ApiMusic.RabbitMq.EventsHandlers;
using MediatR;
using Microsoft.Extensions.Options;
using RabbitMQ.Core.Contracts;
using RabbitMQ.Infrastructure.Bus;
using RabbitMQ.Infrastructure.Ioc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//consume event handler
builder.Services.Configure<UploadSettings>(builder.Configuration.GetSection("Assets"));
builder.Services.AddTransient<IEventHandler<UploadImageEvent>, UploadImageEventHandler>();
builder.Services.AddTransient<IEventHandler<UploadSongEvent>, UploadSongEventHandler>();
builder.Services.AddTransient<UploadImageEventHandler>();
builder.Services.AddTransient<UploadSongEventHandler>();
builder.Services.AddSingleton<IEventBus, RabbitMQBus>(sp =>
{
    var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
    var optionsFactory = sp.GetService<IOptions<RabbitMQSettings>>();

    return new RabbitMQBus(
        sp.GetService<IMediator>(),
        scopeFactory,
        optionsFactory
    );
});
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

var app = builder.Build();



//Consumer Bus Rabbit
var eventBus = app.Services.GetRequiredService<IEventBus>();
eventBus.Subscribe<UploadImageEvent, UploadImageEventHandler>();
eventBus.Subscribe<UploadSongEvent, UploadSongEventHandler>();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
