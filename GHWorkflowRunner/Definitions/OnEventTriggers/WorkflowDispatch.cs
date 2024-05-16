using GHWorkflowRunner.Definitions.Inputs;

namespace GHWorkflowRunner.Definitions.OnEventTriggers;

public sealed class WorkflowDispatch : IOnEventTrigger
{
    public AbstractInput[] Inputs { get; set; } = [];
}