using PD.Workademy.Todo.Application;
using PD.Workademy.Todo.Infrastructure;
using PD.Workademy.Todo.Web;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((context, config) =>
{
    config.ReadFrom.Configuration(context.Configuration);
});

var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);

var startupApplication = new StartupApplication(builder.Configuration);
startupApplication.ConfigureServices(builder.Services);


var startupInfrastructure = new StartupInfrastructure(builder.Configuration);
startupInfrastructure.ConfigureServices(builder.Services);

var app = builder.Build();
startup.Configure(app);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.Run();