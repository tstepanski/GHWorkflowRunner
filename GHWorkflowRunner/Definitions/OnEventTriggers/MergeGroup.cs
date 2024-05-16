namespace GHWorkflowRunner.Definitions.OnEventTriggers;

public sealed class MergeGroup : AbstractSubTypedOnEventTrigger<MergeGroup.Type>
{
    public enum Type : byte
    {
        ChecksRequested = 0
    }
}