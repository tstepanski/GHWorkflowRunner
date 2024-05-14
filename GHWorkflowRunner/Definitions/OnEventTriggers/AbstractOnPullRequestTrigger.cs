namespace GHWorkflowRunner.Definitions.OnEventTriggers;

public abstract class AbstractOnPullRequestTrigger<T> : AbstractSubTypedOnEventTrigger<T>,
    IBranchAndPathConcernedOnEventTrigger where T : Enum
{
    public string[] Branches { get; set; } = [];

    public string[] BranchesIgnore { get; set; } = [];

    public string[] Paths { get; set; } = [];
}