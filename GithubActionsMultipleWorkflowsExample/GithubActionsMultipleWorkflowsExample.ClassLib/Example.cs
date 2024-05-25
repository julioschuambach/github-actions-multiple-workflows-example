namespace GithubActionsMultipleWorkflowsExample.ClassLib
{
    public class Example
    {
        public Guid Id { get; private set; } = Guid.Empty;

        public bool IsIdEmpty()
        {
            return Id == Guid.Empty && Id.ToString() == "00000000-0000-0000-0000-000000000000";
        }
    }
}
