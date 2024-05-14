namespace GHWorkflowRunner.Definitions.OnEventTriggers;

[OnEventTriggerName("repository_dispatch")]
public class RepositoryDispatch : IOnEventTrigger
{
    public string[] Types { get; set; } = [];
}