using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LS_diagram
{
    public class CustomerType
    {
        double chanceToBuy;
        public void Customer(double actualTemperature, string weatherCondition, Day day, Random num, Player player)
        {
            chanceToBuy = 10;
            ActualTemperatureInfluence(actualTemperature);
            WeatherConditionInfluence(weatherCondition);
            PriceInfluence(player.Recipe.price);
            //RecipeInfluence(lemonadeStand);
            DoesBuy(day, num);
        }

        public void ActualTemperatureInfluence(double temperature)
        {
            if (temperature>=75)
            {
                chanceToBuy += temperature - 77;
            }
            else
            {
                chanceToBuy = (75 - temperature) / 2;
            }

        }
        public void WeatherConditionInfluence(string weather)
        {
            switch(weather)
            {
                case "sunny":
                    chanceToBuy += 7;
                    break;
                case "cloudy":
                    chanceToBuy += 3;
                    break;
                case "rainy":
                    chanceToBuy -= 9;
                    break;
                default:
                    chanceToBuy += 0;
                    break;

            }
        }
        public void
    }
}