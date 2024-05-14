using GHWorkflowRunner.Definitions.Jobs;
using GHWorkflowRunner.Definitions.OnEventTriggers;

namespace GHWorkflowRunner.Definitions;

public sealed class Workflow : AbstractJob
{
    public string RunName { get; set; } = string.Empty;

    public IOnEventTrigger[] On { get; set; } = [];

    public Job[] Jobs { get; set; } = [];
}