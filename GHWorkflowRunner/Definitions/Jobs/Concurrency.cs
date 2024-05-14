namespace GHWorkflowRunner.Definitions.Jobs;

public sealed class Concurrency
{
    public string Group { get; set; } = string.Empty;

    public bool CancelInProgress { get; set; }
}