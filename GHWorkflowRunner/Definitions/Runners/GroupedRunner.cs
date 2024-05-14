namespace GHWorkflowRunner.Definitions.Runners;

public sealed class GroupedRunner : IRunner
{
    public string Group { get; set; } = string.Empty;

    public string Labels { get; set; } = string.Empty;
}