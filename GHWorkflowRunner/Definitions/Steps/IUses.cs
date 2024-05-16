namespace GHWorkflowRunner.Definitions.Steps;

public interface IUses
{
    public string Uses { get; set; }

    public Dictionary<string, object> With { get; set; }
}