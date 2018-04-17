namespace ConditionalHandling.Actions
{
    public sealed class GoToRunningAction : IAction
    {
        public void Execute()
        {
            System.Console.WriteLine("Go to running");
        }
    }
}