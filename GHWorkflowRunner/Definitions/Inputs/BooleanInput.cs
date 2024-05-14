namespace GHWorkflowRunner.Definitions.Inputs;

[InputTypeName("boolean")]
public sealed class BooleanInput() : AbstractAllowsDefaultInput<bool>(false), IWorkflowCallAppropriateInput
{
}