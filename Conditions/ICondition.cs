namespace ConditionalHandling.Conditions
{
    public interface ICondition<in T>
    {
        bool CanHandle(T state);
    }
}
