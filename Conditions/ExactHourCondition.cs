using ConditionalHandling.States.Contracts;

namespace ConditionalHandling.Conditions
{
    public sealed class ExactHourCondition : ICondition<ITime>
    {
        private readonly int hour;

        public ExactHourCondition(int hour)
        {
            this.hour = hour;
        }

        public bool CanHandle(ITime state)
        {
            return state.Hour == this.hour;
        }
    }
}