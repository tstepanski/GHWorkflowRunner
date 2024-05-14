namespace GHWorkflowRunner.Definitions.Inputs;

public abstract class AbstractAllowsDefaultInput<T>(T @default) : AbstractInput
{
    public T Default { get; set; } = @default;
}