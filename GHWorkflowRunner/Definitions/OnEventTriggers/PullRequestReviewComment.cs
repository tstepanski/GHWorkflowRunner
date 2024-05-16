namespace GHWorkflowRunner.Definitions.OnEventTriggers;

public sealed class PullRequestReviewComment : AbstractSubTypedOnEventTrigger<PullRequestReviewComment.Type>
{
    public enum Type : byte
    {
        Created = 0,
        Edited = 1,
        Deleted = 2
    }
}