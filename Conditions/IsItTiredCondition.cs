using ConditionalHandling.States.Contracts;

namespace ConditionalHandling.Conditions
{
    public sealed class IsItTiredCondition : ICondition<ITired>
    {
        public bool CanHandle(ITired state)
        {
            return state.IsItTired;
        }
    }
}