using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LS_diagram
{
    public class Weather
    {
        private double Forecast;
        public int realTemp;
        public int degrees;
        public int GetActualWeather;
        int type;
        public string skyType;
        List<string> sky = new List<string>(new string[] { "sunny", "cloudy", "partly-cloudy", "rainy" });
        Random num = new Random();

        public int Temperature()
        {
            degrees = num.Next(50, 100);
            return degrees;
        }

        public string WeatherType()
        {
            type = num.Next(0, 3);
            skyType = sky[type];
            return skyType;
        }
        private double GetForecast()
        {
            int predictTemp = Temperature();
            string predictType = WeatherType();
            string forecast = "Today's forecast is: " + predictType + " and " + predictTemp + " degrees\n";
            Console.WriteLine(forecast);
            string realWeather = GetActualWeather();
            return realWeather;
        }

        public string GetActualWeather(Random random)
        {
            string realWeather;
            int difference = num.Next(-5, 5);
            realTemp = degrees + difference;
            if (realTemp % degrees == 5)
            {
                WeatherType();
                realWeather = "Today's actual weather is: " + skyType + " and " + realTemp + " degrees\n";
            }
            else
            {
                realWeather = "Today's actual weather is: " + skyType + " and " + realTemp + " degrees\n";
            }
            return realWeather;
        }
    }
}