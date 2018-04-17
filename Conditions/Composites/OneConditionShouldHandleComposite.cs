using System.Collections.Generic;
using System.Linq;

namespace ConditionalHandling.Conditions
{
    public sealed class OneConditionShouldHandleComposite<T> : ICondition<T>
    {
        private readonly IEnumerable<ICondition<T>> conditions;

        public OneConditionShouldHandleComposite(IEnumerable<ICondition<T>> conditions)
        {
            this.conditions = conditions;
        }

        public bool CanHandle(T state)
        {
            return this.conditions.Any(condition => condition.CanHandle(state));
        }
    }
}