namespace GHWorkflowRunner.Definitions.Inputs;

public abstract class AbstractInput : IInput
{
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public bool Required { get; set; }
}