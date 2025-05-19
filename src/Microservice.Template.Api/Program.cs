using Microservice.Template.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAppServices(builder.Configuration);

var app = builder.Build();

app.UseHttpAppPipeline();

app.Run();
