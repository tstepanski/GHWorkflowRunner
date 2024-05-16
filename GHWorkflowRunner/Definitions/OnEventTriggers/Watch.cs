namespace GHWorkflowRunner.Definitions.OnEventTriggers;

public class Watch : AbstractSubTypedOnEventTrigger<Watch.Type>
{
    public enum Type : byte
    {
        Started = 0
    }
}