namespace GHWorkflowRunner.Definitions.Jobs;

public abstract class AbstractRunContext
{
    public Shell Shell { get; set; } = Shell.Unspecified;

    public string WorkingDirectory { get; set; } = string.Empty;
}