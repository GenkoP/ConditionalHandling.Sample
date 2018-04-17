using System;
using ConditionalHandling.States.Contracts;

namespace ConditionalHandling.States
{
    public class State : IBoring, IHungry, ITired, ITime, IWork, IWeather
    {
        public bool IsItBoring { get; set; }

        public bool IsItHungry { get; set; }

        public bool IsItAtWork { get; set; }

        public bool IsItTired { get; set; }

        public WeatherType Weather { get; set; }

        public int Hour { get; set; }
    }
}
