namespace GHWorkflowRunner.Definitions.OnEventTriggers;

public sealed class PullRequestReview : AbstractSubTypedOnEventTrigger<PullRequestReview.Type>
{
    public enum Type : byte
    {
        Submitted = 0,
        Edited = 1,
        Dismissed = 2
    }
}