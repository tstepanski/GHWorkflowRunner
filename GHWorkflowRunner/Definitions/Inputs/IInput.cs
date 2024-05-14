namespace GHWorkflowRunner.Definitions.Inputs;

public interface IInput
{
    string Name { get; set; }
    
    string Description { get; set; }
    
    bool Required { get; set; }
}