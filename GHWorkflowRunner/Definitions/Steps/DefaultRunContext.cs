namespace GHWorkflowRunner.Definitions.Steps;

public sealed class DefaultRunContext : IRunContext
{
    public Shell Shell { get; set; } = Shell.Unspecified;

    public string? WorkingDirectory { get; set; }
}