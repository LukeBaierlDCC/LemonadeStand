using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LS_diagram
{
    public class Weather
    {
        public int predictedForecast;
        public int getActualWeather;
        public string weatherCondition;
        public int forecastTemperature;
        public string currentTemperature;

        public Weather()
        {
            GetTemperature();
            GetWeatherCondition();
            GetActualTemperature();
        }

        public void GetTemperature()
        {
            Random rnd = new Random();
            forecastTemperature = rnd.Next(60, 95);
        }
        public void GetWeatherCondition()
        {
            Random rnd = new Random();
            int numberCondition = rnd.Next(0, 4);
            switch(numberCondition)
            {
                case 0:
                    weatherCondition = "sunny";
                    break;
                case 1:
                    weatherCondition = "cloudy";
                    break;
                case 2:
                    weatherCondition = "rainy";
                    break;
            }
        }

        public void GetActualTemperature()
        {
            Random rnd = new Random();
            getActualWeather = rnd.Next(forecastTemperature - 5, forecastTemperature + 5);
        }
    }
}