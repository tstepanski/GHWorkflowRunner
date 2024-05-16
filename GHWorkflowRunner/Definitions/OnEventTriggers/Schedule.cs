namespace GHWorkflowRunner.Definitions.OnEventTriggers;

public class Schedule : IOnEventTrigger
{
    public string[] Cron { get; set; } = [];
}