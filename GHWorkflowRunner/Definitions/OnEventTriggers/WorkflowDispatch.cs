using GHWorkflowRunner.Definitions.Inputs;

namespace GHWorkflowRunner.Definitions.OnEventTriggers;

[OnEventTriggerName("workflow_dispatch")]
public sealed class WorkflowDispatch : IOnEventTrigger
{
    public AbstractInput[] Inputs { get; set; } = [];
}