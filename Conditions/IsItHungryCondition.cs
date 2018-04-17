using ConditionalHandling.States.Contracts;

namespace ConditionalHandling.Conditions
{
    public sealed class IsItHungryCondition : ICondition<IHungry>
    {
        public bool CanHandle(IHungry state)
        {
            return state.IsItHungry;
        }
    }
}