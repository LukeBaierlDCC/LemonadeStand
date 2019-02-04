using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LS_diagram
{
    public class CustomerType
    {
        public void Customer()
        {
            public void Decide(Weather weather, Player player)
            {
                Random rnd = new Random();
                int chance = rnd.Next(1, 6);
                if(chance == 1)
                {
                    PriceFactor(player);
                }
                else if (chance == 2)
                {
                    WeatherFactor(weather, player);
                }
                else if (chance == 3)
                {
                    RecipeFactor(player);
                }
                else
                {
                    Purchase(player);
                }
            }
            public void Purchase(Player player)
            {
                player.Pitcher.cups -= 1;
                player.Wallet += player.Recipe.pricePerCup;
            }
            public void PriceFactor(Player player)
            {
                if(player.Recipe.pricePerCup > 1)
                {
                    Random rnd = new Random();
                    int chance = rnd.Next(1, 100);
                    if(chance > 90)
                    {
                        Purchase(player);
                    }
                }
            }
            public void WeatherFactor(Weather weather, Player player)
            {
            if (weather.realTemp < && weather.skyType == "cloudy" || weather.skyType == "rainy")
                {
                    Random rnd = new Random();
                    int chance = rnd.Next(1, 100);
                    if (chance > 50)
                    {
                        Purchase(player);
                    }
                }
            }
            public void RecipeFactor(Player player)
            {
                if (2 > player.Recipe.numLemon || player.Recipe.numLemon > 8 || player.Recipe.cupsOfSugar < 2)
                {
                    Random rnd = new Random();
                    int chance = rnd.Next(1, 100);
                    if (chance > 50)
                    {
                        Purchase(player);
                    }
                }
            }
        }
    }
}