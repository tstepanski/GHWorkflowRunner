using GHWorkflowRunner.Definitions.Jobs;

namespace GHWorkflowRunner.Definitions;

public sealed class Workflow : AbstractBasicJob
{
    public string RunName { get; set; } = string.Empty;

    public On On { get; set; } = new();

    public Dictionary<string, Job> Jobs { get; set; } = new();
}