namespace GHWorkflowRunner.Definitions.OnEventTriggers;

public sealed class Label : AbstractSubTypedOnEventTrigger<Label.Type>
{
    public enum Type : byte
    {
        Created = 0,
        Edited = 1,
        Deleted = 2
    }
}