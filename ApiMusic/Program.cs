using ApiMusic.Models;
using ApiMusic.RabbitMq.Commands;
using ApiMusic.RabbitMq.Events;
using ApiMusic.RabbitMq.EventsHandlers;
using ApiMusic.RabbitMq.Handlers;
using ApiMusic.Service;
using Infrastructure.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using RabbitMQ.Core.Contracts;
using RabbitMQ.Infrastructure.Bus;
using RabbitMQ.Infrastructure.Ioc;
using System.Security.Cryptography.X509Certificates;

var builder = WebApplication.CreateBuilder(args);


builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true)
    .Build();

if (builder.Environment.EnvironmentName == "Docker")
{
    var certificate = new X509Certificate2(
        builder.Configuration["SSL:PathCert"], 
        builder.Configuration["SSL:Password"]
    );
    builder.WebHost.ConfigureKestrel(options =>
    {
        options.ListenAnyIP(7252, listenOptions =>
        {
            listenOptions.UseHttps(certificate);
        });
    });
}


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
        builder.Configuration["ConnectionStrings:DBContext"],
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
//builder.Services.AddHttpsRedirection(options =>
//{
//    options.HttpsPort = 443; // Configura aquí el puerto HTTPS correcto
//});



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

var environment = app.Services.GetRequiredService<IHostEnvironment>();
var assets = app.Services.GetRequiredService<IOptions<UploadSettings>>().Value;



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

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
                Path.Combine(environment.ContentRootPath, assets.Asset)),
    RequestPath = $"/{ assets.Asset }"
});

app.UseAuthorization();
app.MapControllers();
app.Run();
