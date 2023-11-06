using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Sandbox.Console;

public class Foo(ILogger<Foo> logger, IOptions<SandboxSettings> settings) : IFoo
{
  public void DoSomething() => logger.LogInformation("Doing something in Foo: {Foo}", settings.Value.Something);
}
