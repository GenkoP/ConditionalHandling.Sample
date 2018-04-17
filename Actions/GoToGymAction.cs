namespace ConditionalHandling.Actions
{
    public sealed class GoToGymAction : IAction
    {
        public void Execute()
        {
            System.Console.WriteLine("Go to gym");
        }
    }
}