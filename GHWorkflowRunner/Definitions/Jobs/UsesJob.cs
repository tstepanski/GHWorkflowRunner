using GHWorkflowRunner.Definitions.Inputs;
using GHWorkflowRunner.Definitions.Steps;

namespace GHWorkflowRunner.Definitions.Jobs;

public sealed class UsesJob : AbstractJob, IUses
{
    public Secret[] Secrets { get; set; } = [];
    public string Uses { get; set; } = string.Empty;

    public Dictionary<string, object> With { get; set; } = new();
}