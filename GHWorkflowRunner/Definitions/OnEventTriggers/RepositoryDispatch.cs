namespace GHWorkflowRunner.Definitions.OnEventTriggers;

public class RepositoryDispatch : IOnEventTrigger
{
    public string[] Types { get; set; } = [];
}