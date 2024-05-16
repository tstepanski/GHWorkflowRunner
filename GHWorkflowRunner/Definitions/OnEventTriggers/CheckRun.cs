namespace GHWorkflowRunner.Definitions.OnEventTriggers;

public sealed class CheckRun : AbstractSubTypedOnEventTrigger<CheckRun.Type>
{
    public enum Type : byte
    {
        Created = 0,
        ReRequested = 1,
        Completed = 2,
        RequestedAction = 3
    }
}