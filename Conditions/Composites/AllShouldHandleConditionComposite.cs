using System.Collections.Generic;
using System.Linq;

namespace ConditionalHandling.Conditions
{
    public sealed class AllShouldHandleConditionComposite<T> : ICondition<T>
    {
        private readonly IEnumerable<ICondition<T>> conditions;

        public AllShouldHandleConditionComposite(IEnumerable<ICondition<T>> conditions)
        {
            this.conditions = conditions;
        }

        public bool CanHandle(T state)
        {
            return conditions.All(condition => condition.CanHandle(state));
        }
    }
}