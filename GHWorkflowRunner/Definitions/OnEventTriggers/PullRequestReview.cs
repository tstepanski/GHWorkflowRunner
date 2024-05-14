namespace GHWorkflowRunner.Definitions.OnEventTriggers;

[OnEventTriggerName("pull_request_review")]
public sealed class PullRequestReview : AbstractSubTypedOnEventTrigger<PullRequestReview.Type>
{
    public enum Type : byte
    {
        Submitted = 0,
        Edited = 1,
        Dismissed = 2
    }
}