using YamlDotNet.Serialization;

namespace GHWorkflowRunner.Definitions.Steps;

public sealed class RunStep : AbstractStep, IRunContext
{
    private string _run = string.Empty;

    public string Run
    {
        get => _run;
        set
        {
            _run = value;

            RunLines = value
                .Split(['\n', '\r'])
                .Select(line => line.Trim())
                .Where(line => string.IsNullOrWhiteSpace(line) is false)
                .ToArray();
        }
    }

    [YamlIgnore] public string[] RunLines { get; private set; } = [];

    public Shell Shell { get; set; } = Shell.Unspecified;

    public string? WorkingDirectory { get; set; }
}