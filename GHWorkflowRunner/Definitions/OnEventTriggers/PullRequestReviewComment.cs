namespace GHWorkflowRunner.Definitions.OnEventTriggers;

[OnEventTriggerName("pull_request_review_comment")]
public sealed class PullRequestReviewComment : AbstractSubTypedOnEventTrigger<PullRequestReviewComment.Type>
{
    public enum Type : byte
    {
        Created = 0,
        Edited = 1,
        Deleted = 2
    }
}