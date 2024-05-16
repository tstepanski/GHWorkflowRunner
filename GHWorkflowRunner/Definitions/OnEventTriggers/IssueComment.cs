namespace GHWorkflowRunner.Definitions.OnEventTriggers;

public sealed class IssueComment : AbstractSubTypedOnEventTrigger<IssueComment.Type>
{
    public enum Type : byte
    {
        Created = 0,
        Edited = 1,
        Deleted = 2
    }
}