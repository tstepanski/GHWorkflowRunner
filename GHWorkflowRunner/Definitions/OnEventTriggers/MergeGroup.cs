namespace GHWorkflowRunner.Definitions.OnEventTriggers;

[OnEventTriggerName("merge_group")]
public sealed class MergeGroup : AbstractSubTypedOnEventTrigger<MergeGroup.Type>
{
    public enum Type : byte
    {
        ChecksRequested = 0
    }
}