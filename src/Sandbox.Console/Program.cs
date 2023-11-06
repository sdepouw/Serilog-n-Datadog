using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Sandbox.Console;

var builder = Host.CreateDefaultBuilder().ConfigureServices((_, services) =>
{
  services.AddTransient<IFoo, Foo>();
  services.AddSingleton<SandboxApp>();
});

using var host = builder.Build();
using var scope = host.Services.CreateScope();
try
{
  scope.ServiceProvider.GetRequiredService<SandboxApp>().Go();
}
catch (Exception e)
{
  Console.WriteLine(e.Message);
}
