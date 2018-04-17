using ConditionalHandling.States.Contracts;

namespace ConditionalHandling.Conditions
{
    public sealed class IsItAtWorkCondition : ICondition<IWork>
    {
        public bool CanHandle(IWork state)
        {
            return state.IsItAtWork;
        }
    }
}