namespace GHWorkflowRunner.Definitions.OnEventTriggers;

public sealed class Discussion : AbstractSubTypedOnEventTrigger<Discussion.Type>
{
    public enum Type : byte
    {
        Created = 0,
        Edited = 1,
        Deleted = 2,
        Transferred = 3,
        Pinned = 4,
        Unpinned = 5,
        Labeled = 6,
        Unlabeled = 7,
        Locked = 8,
        Unlocked = 9,
        CategoryChanged = 10,
        Answered = 11,
        Unanswered = 12
    }
}