namespace GHWorkflowRunner.Definitions.OnEventTriggers;

public interface IBranchAndPathConcernedOnEventTrigger : IBranchConcernedOnEventTrigger
{
    string[] Paths { get; set; }
}