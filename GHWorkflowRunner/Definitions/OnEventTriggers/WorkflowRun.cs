namespace GHWorkflowRunner.Definitions.OnEventTriggers;

[OnEventTriggerName("workflow_run")]
public sealed class WorkflowRun : AbstractSubTypedOnEventTrigger<WorkflowRun.Type>,
    IBranchConcernedOnEventTrigger
{
    public string[] Workflows { get; set; } = [];

    public string[] Branches { get; set; } = [];

    public string[] BranchesIgnore { get; set; } = [];

    public enum Type : byte
    {
        Completed = 0,
        Requested = 1,
        InProgress = 2
    }
}