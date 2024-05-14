namespace GHWorkflowRunner.Definitions.OnEventTriggers;

[OnEventTriggerName("schedule")]
public class Schedule : IOnEventTrigger
{
    public string[] Cron { get; set; } = [];
}