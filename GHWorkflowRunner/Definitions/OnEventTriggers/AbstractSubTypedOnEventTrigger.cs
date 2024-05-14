namespace GHWorkflowRunner.Definitions.OnEventTriggers;

public abstract class AbstractSubTypedOnEventTrigger<T> : IOnEventTrigger where T : Enum
{
    public T[] Types { get; set; } = [];
}