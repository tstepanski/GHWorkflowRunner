namespace GHWorkflowRunner.Definitions.Steps;

public abstract class AbstractStep
{
    public string? Id { get; set; }

    public string? If { get; set; }

    public string Name { get; set; } = string.Empty;

    public Dictionary<string, string> Env { get; set; } = new();

    public bool ContinueOnError { get; set; }

    public double? TimeoutMinutes { get; set; }
}