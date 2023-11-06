using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Sandbox.Console;

HostApplicationBuilder builder = Host.CreateApplicationBuilder();
builder.Services.AddTransient<IFoo, Foo>();
builder.Services.AddSingleton<SandboxApp>();
builder.Services.AddOptions<SandboxSettings>()
  .BindConfiguration(nameof(SandboxSettings))
  .ValidateDataAnnotations()
  .ValidateOnStart();
string environmentName = builder.Environment.EnvironmentName;
using IHost host = builder.Build();
using IServiceScope scope = host.Services.CreateScope();
ILogger<Program> logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
try
{
  logger.LogInformation("Starting in Environment {EnvironmentName}", environmentName);
  scope.ServiceProvider.GetRequiredService<SandboxApp>().Go();
}
catch (Exception e)
{
  logger.LogError(e, "Error starting");
}
