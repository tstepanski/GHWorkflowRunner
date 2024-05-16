namespace GHWorkflowRunner.Definitions.OnEventTriggers;

public sealed class Issues : AbstractSubTypedOnEventTrigger<Issues.Type>
{
    public enum Type : byte
    {
        Opened = 0,
        Edited = 1,
        Deleted = 2,
        Transferred = 3,
        Pinned = 4,
        Unpinned = 5,
        Closed = 6,
        Reopened = 7,
        Assigned = 8,
        Unassigned = 9,
        Labeled = 10,
        Unlabeled = 11,
        Locked = 12,
        Unlocked = 13,
        Milestoned = 14,
        Demilestoned = 15
    }
}