using GHWorkflowRunner.Definitions.Outputs;
using GHWorkflowRunner.Definitions.Steps;

namespace GHWorkflowRunner.Definitions.Jobs;

public sealed class Job : AbstractJob
{
    public Output[] Outputs { get; set; } = [];

    public AbstractStep[] Steps { get; set; } = [];
}