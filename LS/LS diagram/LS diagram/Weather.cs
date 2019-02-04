using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LS_diagram
{
    public class Weather
    {
        private double Forecast;
        private int SunnyDay;
        private int RainyDay;
        private int CloudyDay;

        public string GetForecast()
        {
            int predictTemp = Temperature();
            string predictType = WeatherType();
            string forecast = "The predicted weather is: " + predictType + " and " + predictTemp + " degrees\n";
            Console.WriteLine(forecast);
            string realWeather = ActualWeather();
            return skyType;
            }
        }

        public string GetActualWeather()
        {
            string GetActualWeather;
            int difference = NotFiniteNumberException.Next(-5,5);
            realTemp = degrees + difference;
            if (realTemp % degrees == 5)
            {
                ActualWeather();
                realWeather = "Today's forecast is: " +  + " and " + realTemp + " degrees\n";
            }
            else
            {
                realWeather = "Today's forecast is: " +  + " and " + realTemp + " degrees\n";
            }
            return realWeather;
            
        }

    }
}