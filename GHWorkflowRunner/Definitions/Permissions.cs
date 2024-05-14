namespace GHWorkflowRunner.Definitions;

public sealed class Permissions
{
    public Level Actions { get; set; }
    public Level Checks { get; set; }
    public Level Contents { get; set; }
    public Level Deployments { get; set; }
    public Level IdToken { get; set; }
    public Level Issues { get; set; }
    public Level Discussions { get; set; }
    public Level Packages { get; set; }
    public Level Pages { get; set; }
    public Level PullRequests { get; set; }
    public Level RepositoryProjects { get; set; }
    public Level SecurityEvents { get; set; }
    public Level Statuses { get; set; }

    public static Permissions None() => new();

    public static Permissions ReadAll() => new()
    {
        Actions = Level.Read,
        Checks = Level.Read,
        Contents = Level.Read,
        Deployments = Level.Read,
        IdToken = Level.Read,
        Issues = Level.Read,
        Discussions = Level.Read,
        Packages = Level.Read,
        Pages = Level.Read,
        PullRequests = Level.Read,
        RepositoryProjects = Level.Read,
        SecurityEvents = Level.Read,
        Statuses = Level.Read
    };

    public static Permissions WriteAll() => new()
    {
        Actions = Level.Write,
        Checks = Level.Write,
        Contents = Level.Write,
        Deployments = Level.Write,
        IdToken = Level.Write,
        Issues = Level.Write,
        Discussions = Level.Write,
        Packages = Level.Write,
        Pages = Level.Write,
        PullRequests = Level.Write,
        RepositoryProjects = Level.Write,
        SecurityEvents = Level.Write,
        Statuses = Level.Write
    };

    public enum Level
    {
        None = 0,
        Read = 1,
        Write = 2
    }
}