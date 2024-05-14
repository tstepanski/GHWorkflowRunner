namespace GHWorkflowRunner.Definitions.OnEventTriggers;

[OnEventTriggerName("pull_request_target")]
public sealed class PullRequestTarget : AbstractOnPullRequestTrigger<PullRequestTarget.Type>
{
    public enum Type : byte
    {
        Assigned = 0,
        Unassigned = 1,
        Labeled = 2,
        Unlabeled = 3,
        Opened = 4,
        Edited = 5,
        Closed = 6,
        Reopened = 7,
        Synchronize = 8,
        ConvertedToDraft = 9,
        ReadyForReview = 10,
        Locked = 11,
        Unlocked = 12,
        ReviewRequested = 13,
        ReviewRequestRemoved = 14,
        AutoMergeEnabled = 15,
        AutoMergeDisabled = 16
    }
}