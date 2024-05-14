namespace GHWorkflowRunner.Definitions.OnEventTriggers;

public interface IBranchConcernedOnEventTrigger : IOnEventTrigger
{
    string[] Branches { get; set; }
    
    string[] BranchesIgnore { get; set; }
}