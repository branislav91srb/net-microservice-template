using Microservice.Template.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAppServices(builder.Configuration);

builder.Services.AddMediatR(conf =>
{
    conf.RegisterServicesFromAssemblies(typeof(Microservice.Template.Application.IProjectReference).Assembly, typeof(Microservice.Template.Infrastructure.IProjectReference).Assembly);
});

var app = builder.Build();

app.UseHttpAppPipeline();

app.Run();
