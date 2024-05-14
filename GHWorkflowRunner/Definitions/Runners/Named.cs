namespace GHWorkflowRunner.Definitions.Runners;

public sealed class Named : IRunner
{
    public string Value { get; set; } = string.Empty;
}