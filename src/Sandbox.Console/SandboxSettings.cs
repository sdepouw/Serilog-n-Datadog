using System.ComponentModel.DataAnnotations;

namespace Sandbox.Console;

public class SandboxSettings
{
  [Required]
  public string Something { get; set; } = "";
}
