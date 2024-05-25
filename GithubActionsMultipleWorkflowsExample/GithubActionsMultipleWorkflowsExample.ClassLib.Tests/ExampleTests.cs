namespace GithubActionsMultipleWorkflowsExample.ClassLib.Tests
{
    [TestClass]
    public class ExampleTests
    {
        [TestMethod]
        public void WhenExampleCreatedIdMustBeEmpty()
        {
            Example example = new Example();
            Assert.IsTrue(example.IsIdEmpty(), "The Example Id (Guid) is not Empty (Guid.Empty).");
        }
    }
}
