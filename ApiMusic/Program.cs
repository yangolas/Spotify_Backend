using ApiMusic.Models;
using ApiMusic.RabbitMq.Commands;
using ApiMusic.RabbitMq.Events;
using ApiMusic.RabbitMq.EventsHandlers;
using ApiMusic.RabbitMq.Handlers;
using ApiMusic.Service;
using Infrastructure.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RabbitMQ.Core.Contracts;
using RabbitMQ.Infrastructure.Bus;
using RabbitMQ.Infrastructure.Ioc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddHttpClient();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ISectionService, SectionService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<ICardService, CardService>();
builder.Services.AddTransient<IRequestHandler<UploadImageCommand, bool>, UploadImageCommandHandler>();
builder.Services.AddTransient<IRequestHandler<UploadSongCommand, bool>, UploadSongCommandHandler>();

builder.Services.AddDbContext<MusicContext>(options => 
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:DBContextLocal"],
        build => build.MigrationsAssembly("ApiMusic")
    )
);

builder.Services.Configure<RabbitMQSettings>(builder.Configuration.GetSection("RabbitMQSettings"));
builder.Services.RegisterServices(builder.Configuration);

//consume event handler
builder.Services.Configure<UploadSettings>(builder.Configuration.GetSection("Assets"));
builder.Services.AddTransient<IEventHandler<UploadImageEvent>, UploadImageEventHandler>();
builder.Services.AddTransient<IEventHandler<UploadSongEvent>, UploadSongEventHandler>();
builder.Services.AddTransient<UploadImageEventHandler>();
builder.Services.AddTransient<UploadSongEventHandler>();

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

app.UseCors();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthorization();
app.MapControllers();
app.Run();
