namespace GHWorkflowRunner.Definitions.Steps;

public interface IRunContext
{
    public Shell Shell { get; set; }

    public string? WorkingDirectory { get; set; }
}