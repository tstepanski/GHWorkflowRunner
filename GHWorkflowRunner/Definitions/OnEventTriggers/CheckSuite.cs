namespace GHWorkflowRunner.Definitions.OnEventTriggers;

[OnEventTriggerName("check_suite")]
public sealed class CheckSuite : AbstractSubTypedOnEventTrigger<CheckSuite.Type>
{
    public enum Type : byte
    {
        Completed = 0
    }
}