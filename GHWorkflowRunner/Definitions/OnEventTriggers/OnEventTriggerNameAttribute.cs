namespace GHWorkflowRunner.Definitions.OnEventTriggers;

[AttributeUsage(AttributeTargets.Class)]
public sealed class OnEventTriggerNameAttribute(string key) : Attribute
{
    public string Key { get; } = key;
}