namespace GHWorkflowRunner.Definitions.Inputs;

[AttributeUsage(AttributeTargets.Class)]
public sealed class InputTypeNameAttribute(string name) : Attribute
{
    public string Name { get; } = name;
}