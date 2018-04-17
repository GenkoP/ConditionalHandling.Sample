namespace ConditionalHandling.Actions
{
    public sealed class GoToDiscoAction : IAction
    {
        public void Execute()
        {
            System.Console.WriteLine("Go to disco");
        }
    }
}