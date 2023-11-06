namespace Sandbox.Console;

public class SandboxApp(IFoo foo)
{
  public void Go()
  {
    foo.DoSomething();
  }
}
