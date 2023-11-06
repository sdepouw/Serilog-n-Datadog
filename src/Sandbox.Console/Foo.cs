using Microsoft.Extensions.Logging;

namespace Sandbox.Console;

public class Foo(ILogger<Foo> logger) : IFoo
{
  public void DoSomething() => logger.LogInformation("Doing something in Foo");
}
