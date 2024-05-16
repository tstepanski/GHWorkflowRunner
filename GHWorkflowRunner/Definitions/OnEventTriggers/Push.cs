namespace GHWorkflowRunner.Definitions.OnEventTriggers;

public sealed class Push : IBranchAndPathConcernedOnEventTrigger
{
    public string[] Branches { get; set; } = [];

    public string[] BranchesIgnore { get; set; } = [];

    public string[] Paths { get; set; } = [];
}