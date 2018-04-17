using System;
using ConditionalHandling.States;
using ConditionalHandling.Actions;
using ConditionalHandling.Conditions;
using System.Collections.Generic;

namespace ConditionalHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<State> states = new List<State>()
            {
                new State()
                {
                    IsItBoring = true,
                    IsItHungry = true,
                    IsItTired = true,
                    IsItAtWork = true,
                    Hour = 12,
                    Weather = WeatherType.Sunny,
                },
                new State()
                {
                    IsItBoring = true,
                    IsItHungry = true,
                    IsItTired = true,
                    IsItAtWork = true,
                    Hour = 12,
                    Weather = WeatherType.Sunny,
                },
                new State()
                {
                    IsItBoring = true,
                    IsItHungry = true,
                    IsItTired = true,
                    IsItAtWork = true,
                    Hour = 12,
                    Weather = WeatherType.Sunny,
                },
                new State()
                {
                    IsItBoring = false,
                    IsItHungry = false,
                    IsItTired = true,
                    IsItAtWork = true,
                    Hour = 3,
                    Weather = WeatherType.Cold,
                },
                new State()
                {
                    IsItBoring = true,
                    IsItHungry = true,
                    IsItTired = false,
                    IsItAtWork = false,
                    Hour = 17,
                    Weather = WeatherType.Raining,
                },
                new State()
                {
                    IsItBoring = false,
                    IsItHungry = false,
                    IsItTired = true,
                    IsItAtWork = true,
                    Hour = 12,
                    Weather = WeatherType.Sunny,
                },
            };

            IEnumerable<Handler<State>> handlers = new List<Handler<State>>()
            {
                new Handler<State>(new IsItHungryCondition(), new GoToRestorantAction()),
                new Handler<State>(new WeatherTypeCondition(WeatherType.Sunny), new GoToGymAction()),
                new Handler<State>(new IsItAtWorkCondition(), new WatchTVAction()),
                
                new Handler<State>(new AllShouldHandleConditionComposite<State>(new List<ICondition<State>>()
                {
                    new IsItHungryCondition(),
                    new WeatherTypeCondition(WeatherType.Raining),
                    new IsItAtWorkCondition(),
                })
                , new GoToGymAction()),
                
                new Handler<State>(new AllShouldHandleConditionComposite<State>(new List<ICondition<State>>()
                {
                    new IsItHungryCondition(),
                    new WeatherTypeCondition(WeatherType.Raining),
                    new IsItAtWorkCondition(),
                }),
                new ActionComposite(new List<IAction>()
                {
                    new GoToRestorantAction(),
                    new DrinkAction(),
                    new WatchTVAction(),
                })),
                
                new Handler<State>(new OneConditionShouldHandleComposite<State>(new List<ICondition<State>>()
                {
                    new ExactHourCondition(3),
                    new WeatherTypeCondition(WeatherType.Cold),
                    new IsItAtWorkCondition(),
                }),
                new ActionComposite(new List<IAction>()
                {
                    new GoToDiscoAction(),
                    new PickUpGirlsAction(),
                    new DrinkAction()
                })),
            };

            foreach (State state in states)
            {
                foreach (Handler<State> handler in handlers)
                {
                    handler.Handle(state);
                }
            }
        }
    }
}
