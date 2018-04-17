namespace ConditionalHandling.Actions
{
    public sealed class GoToSleepAction : IAction
    {
        public void Execute()
        {
            System.Console.WriteLine("Go to sleep");
        }
    }
}