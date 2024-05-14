namespace GHWorkflowRunner.Definitions.Jobs;

public abstract class AbstractJob
{
    public string Name { get; set; } = string.Empty;

    public Permissions Permissions { get; set; } = Permissions.None();

    public Dictionary<string, string> Env { get; set; } = new();

    public Defaults Defaults { get; set; } = new();

    public Concurrency? Concurrency { get; set; }
}