namespace GHWorkflowRunner.Definitions.Jobs;

public enum Shell : byte
{
    Unspecified = 0,
    Bash = 1,
    PowershellCore = 2,
    Python = 3,
    Shell = 4,
    CommandPrompt = 5,
    PowershellDesktop = 6
}