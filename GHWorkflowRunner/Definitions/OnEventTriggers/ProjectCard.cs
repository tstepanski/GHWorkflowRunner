namespace GHWorkflowRunner.Definitions.OnEventTriggers;

public sealed class ProjectCard : AbstractSubTypedOnEventTrigger<ProjectCard.Type>
{
    public enum Type : byte
    {
        Created = 0,
        Moved = 1,
        Converted = 2,
        Edited = 3,
        Deleted = 4
    }
}