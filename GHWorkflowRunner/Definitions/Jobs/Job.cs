using GHWorkflowRunner.Definitions.Outputs;
using GHWorkflowRunner.Definitions.Runners;

namespace GHWorkflowRunner.Definitions.Jobs;

public sealed class Job : AbstractJob
{
    public string[] Needs { get; set; } = [];

    public string? If { get; set; }

    public IRunner RunsOn { get; set; } = new Named();

    public Output[] Outputs { get; set; } = [];
}