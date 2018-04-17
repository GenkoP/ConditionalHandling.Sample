using ConditionalHandling.Actions;
using ConditionalHandling.Conditions;

namespace ConditionalHandling
{
    public sealed class Handler<T>
    {
        private readonly IAction action;
        private readonly ICondition<T> condition;

        public Handler(ICondition<T> condition, IAction action)
        {
            this.action = action;
            this.condition = condition;
        }

        public void Handle(T state)
        {
            if(this.condition.CanHandle(state))
            {
                this.action.Execute();
            }
        }
    }
}
