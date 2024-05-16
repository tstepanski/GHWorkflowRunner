namespace GHWorkflowRunner.Definitions.Steps;

public sealed class UsesStep : AbstractStep, IUses
{
    public string Uses { get; set; } = string.Empty;

    public Dictionary<string, object> With { get; set; } = new();
}