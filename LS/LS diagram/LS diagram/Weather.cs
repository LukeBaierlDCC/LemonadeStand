using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LS_diagram
{
    public class Weather
    {
        private int SunnyDay;
        private int RainyDay;
        private int CloudyDay;

        public void GetForecast()
        {
            Random rnd = new Random();
            int caseSwitch = rnd.Next(1,4);

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
            }
        }

        public void GetActualWeather()
        {
            int caseSwitch = 
        }

    }
}