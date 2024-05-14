using GHWorkflowRunner.Definitions.Inputs;
using GHWorkflowRunner.Definitions.Outputs;

namespace GHWorkflowRunner.Definitions.OnEventTriggers;

[OnEventTriggerName("workflow_call")]
public class WorkflowCall : IOnEventTrigger
{
    public IWorkflowCallAppropriateInput[] Inputs { get; set; } = [];

    public Output[] Outputs { get; set; } = [];

    public Secret[] Secrets { get; set; } = [];
}