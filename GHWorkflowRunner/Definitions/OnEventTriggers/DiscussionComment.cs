namespace GHWorkflowRunner.Definitions.OnEventTriggers;

[OnEventTriggerName("discussion_comment")]
public sealed class DiscussionComment : AbstractSubTypedOnEventTrigger<DiscussionComment.Type>
{
    public enum Type : byte
    {
        Created = 0,
        Edited = 1,
        Deleted = 2
    }
}