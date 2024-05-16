namespace GHWorkflowRunner.Definitions.OnEventTriggers;

public sealed class Milestone : AbstractSubTypedOnEventTrigger<Milestone.Type>
{
    public enum Type : byte
    {
        Created = 0,
        Closed = 1,
        Opened = 2,
        Edited = 3,
        Deleted = 4
    }
}