namespace GHWorkflowRunner.Definitions.OnEventTriggers;

public sealed class WorkflowRun : AbstractSubTypedOnEventTrigger<WorkflowRun.Type>,
    IBranchConcernedOnEventTrigger
{
    public enum Type : byte
    {
        Completed = 0,
        Requested = 1,
        InProgress = 2
    }

    public string[] Workflows { get; set; } = [];

    public string[] Branches { get; set; } = [];

    public string[] BranchesIgnore { get; set; } = [];
}