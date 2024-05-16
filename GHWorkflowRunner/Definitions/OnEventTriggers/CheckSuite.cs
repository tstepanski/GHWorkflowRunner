namespace GHWorkflowRunner.Definitions.OnEventTriggers;

public sealed class CheckSuite : AbstractSubTypedOnEventTrigger<CheckSuite.Type>
{
    public enum Type : byte
    {
        Completed = 0
    }
}