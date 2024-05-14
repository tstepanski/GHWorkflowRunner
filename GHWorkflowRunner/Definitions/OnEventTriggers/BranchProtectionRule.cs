namespace GHWorkflowRunner.Definitions.OnEventTriggers;

[OnEventTriggerName("branch_protection_rule")]
public sealed class BranchProtectionRule : AbstractSubTypedOnEventTrigger<BranchProtectionRule.Type>
{
    public enum Type : byte
    {
        Created = 0,
        Edited = 1,
        Deleted = 2
    }
}