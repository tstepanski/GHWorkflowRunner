using GHWorkflowRunner.Definitions.Runners;
using YamlDotNet.Serialization;

namespace GHWorkflowRunner.Definitions.Jobs;

public abstract class AbstractJob : AbstractBasicJob
{
    public string[] Needs { get; set; } = [];

    public string? If { get; set; }

    [YamlMember(Alias = "runs-on", ApplyNamingConventions = false)]
    public IRunner RunsOn { get; set; } = new Named();

    public double? TimeoutMinutes { get; set; }
}