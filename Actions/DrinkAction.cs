namespace ConditionalHandling.Actions
{
    public sealed class DrinkAction : IAction
    {
        public void Execute()
        {
            System.Console.WriteLine("Drink drink");
        }
    }
}