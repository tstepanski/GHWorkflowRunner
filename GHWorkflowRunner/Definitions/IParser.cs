namespace GHWorkflowRunner.Definitions;

public interface IParser
{
    Task<Workflow> ParseAsync(Stream stream, CancellationToken cancellationToken = default);
}