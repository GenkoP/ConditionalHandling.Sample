using System.Collections.Generic;

namespace ConditionalHandling.Actions
{
    public sealed class ActionComposite : IAction
    {
        private readonly IEnumerable<IAction> actions;

        public ActionComposite(IEnumerable<IAction> actions)
        {
            this.actions = actions;
        }

        public void Execute()
        {
            foreach (IAction action in this.actions)
            {
                action.Execute();
                System.Console.WriteLine("Then");
            }
        }
    }
}