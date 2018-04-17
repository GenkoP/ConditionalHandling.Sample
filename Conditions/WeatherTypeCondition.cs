using ConditionalHandling.States;
using ConditionalHandling.States.Contracts;

namespace ConditionalHandling.Conditions
{
    public sealed class WeatherTypeCondition : ICondition<IWeather>
    {
        private readonly WeatherType weatherType;

        public WeatherTypeCondition(WeatherType weatherType)
        {
            this.weatherType = weatherType;
        }

        public bool CanHandle(IWeather state)
        {
            return state.Weather == weatherType;
        }
    }
}