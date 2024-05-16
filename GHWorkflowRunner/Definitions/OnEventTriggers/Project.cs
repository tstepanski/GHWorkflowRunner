namespace GHWorkflowRunner.Definitions.OnEventTriggers;

public sealed class Project : AbstractSubTypedOnEventTrigger<Project.Type>
{
    public enum Type : byte
    {
        Created = 0,
        Closed = 1,
        Reopened = 2,
        Edited = 3,
        Deleted = 4
    }
}