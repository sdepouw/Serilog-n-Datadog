using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Sandbox.Console;

public class Foo(ILogger<Foo> logger, IOptions<SandboxSettings> settings) : IFoo
{
  public void DoSomething()
  {
    logger.LogInformation("Doing something in Foo: {Something}", settings.Value.Something);
    List<LogLevel> logLevels = new()
    {
      LogLevel.Trace,
      LogLevel.Debug,
      LogLevel.Information,
      LogLevel.Warning,
      LogLevel.Error,
      LogLevel.Critical,
      LogLevel.None
    };
    foreach (LogLevel level in logLevels)
    {
      logger.Log(level, "Logging a {Level}!", level);
    }
  }
}
