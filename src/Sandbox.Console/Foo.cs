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
      LogLevel.None, // Never logged
      LogLevel.Trace, // Verbose
      LogLevel.Debug, // Debug
      LogLevel.Information, // Information (default when non Minimum set)
      LogLevel.Warning, // Warning
      LogLevel.Error, // Error
      LogLevel.Critical // Fatal
    };
    foreach (LogLevel level in logLevels)
    {
      logger.Log(level, "Logging a {Level}!", level);
    }
  }
}
