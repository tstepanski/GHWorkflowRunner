namespace GHWorkflowRunner.Definitions.OnEventTriggers;

[OnEventTriggerName("watch")]
public class Watch : AbstractSubTypedOnEventTrigger<Watch.Type>
{
    public enum Type : byte
    {
        Started = 0
    }
}