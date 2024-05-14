namespace GHWorkflowRunner.Definitions.OnEventTriggers;

[OnEventTriggerName("project_column")]
public sealed class ProjectColumn : AbstractSubTypedOnEventTrigger<ProjectColumn.Type>
{
    public enum Type : byte
    {
        Created = 0,
        Updated = 1,
        Moved = 2,
        Deleted = 3
    }
}