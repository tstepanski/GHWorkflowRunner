namespace GHWorkflowRunner.Definitions.OnEventTriggers;

[OnEventTriggerName("registry_package")]
public class RegistryPackage : AbstractSubTypedOnEventTrigger<RegistryPackage.Type>
{
    public enum Type : byte
    {
        Published = 0,
        Updated = 1
    }
}