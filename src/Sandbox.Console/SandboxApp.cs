using Microsoft.Extensions.Logging;

namespace Sandbox.Console;

public class SandboxApp(IFoo foo, ILogger<SandboxApp> logger)
{
  public void Go()
  {
    logger.LogInformation("Started Sandbox App");
    foo.DoSomething();
  }
}
