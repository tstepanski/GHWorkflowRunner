using GHWorkflowRunner.Definitions.OnEventTriggers;

namespace GHWorkflowRunner.Definitions;

public sealed class On
{
    public BranchProtectionRule? BranchProtectionRule { get; set; }
    public CheckRun? CheckRun { get; set; }
    public CheckSuite? CheckSuite { get; set; }
    public Create? Create { get; set; }
    public Delete? Delete { get; set; }
    public Deployment? Deployment { get; set; }
    public DeploymentStatus? DeploymentStatus { get; set; }
    public Discussion? Discussion { get; set; }
    public DiscussionComment? DiscussionComment { get; set; }
    public Fork? Fork { get; set; }
    public Gollum? Gollum { get; set; }
    public IssueComment? IssueComment { get; set; }
    public Issues? Issues { get; set; }
    public Label? Label { get; set; }
    public MergeGroup? MergeGroup { get; set; }
    public Milestone? Milestone { get; set; }
    public PageBuild? PageBuild { get; set; }
    public Project? Project { get; set; }
    public ProjectCard? ProjectCard { get; set; }
    public ProjectColumn? ProjectColumn { get; set; }
    public Public? Public { get; set; }
    public PullRequest? PullRequest { get; set; }
    public PullRequestReview? PullRequestReview { get; set; }
    public PullRequestReviewComment? PullRequestReviewComment { get; set; }
    public PullRequestTarget? PullRequestTarget { get; set; }
    public Push? Push { get; set; }
    public RegistryPackage? RegistryPackage { get; set; }
    public RepositoryDispatch? RepositoryDispatch { get; set; }
    public Schedule? Schedule { get; set; }
    public Status? Status { get; set; }
    public Watch? Watch { get; set; }
    public WorkflowCall? WorkflowCall { get; set; }
    public WorkflowDispatch? WorkflowDispatch { get; set; }
    public WorkflowRun? WorkflowRun { get; set; }
}