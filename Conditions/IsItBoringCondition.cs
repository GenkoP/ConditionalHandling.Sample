using ConditionalHandling.States.Contracts;

namespace ConditionalHandling.Conditions
{
    public sealed class IsItBoringCondition : ICondition<IBoring>
    {
        public bool CanHandle(IBoring state)
        {
            return state.IsItBoring;
        }
    }
}