namespace GHWorkflowRunner.Definitions.OnEventTriggers;

[OnEventTriggerName("pull_request")]
public sealed class PullRequest : AbstractOnPullRequestTrigger<PullRequest.Type>
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
        Locked = 10,
        Unlocked = 11,
        Enqueued = 12,
        Dequeued = 13,
        Milestoned = 14,
        Demilestoned = 15,
        ReadyForReview = 16,
        ReviewRequested = 17,
        ReviewRequestRemoved = 18,
        AutoMergeEnabled = 19,
        AutoMergeDisabled = 20
    }
}