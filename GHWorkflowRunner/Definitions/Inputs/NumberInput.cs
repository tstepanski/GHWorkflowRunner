namespace GHWorkflowRunner.Definitions.Inputs;

[InputTypeName("number")]
public sealed class NumberInput() : AbstractAllowsDefaultInput<decimal>(0), IWorkflowCallAppropriateInput
{
}