using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LS_diagram
{
    public class Game
    {
        public List<Day> Days;

        public Player player;

        public StoreClass store;

        public Rules rules;

        public Game()
        {
            Days = new List<Day>();

            player = new Player();

            store = new StoreClass();

            rules = new Rules();
        }
        public void GenerateDays(int numberOfDays)
        {
            for (int i = 0; i < numberOfDays; i++)
            {
                Day day = new Day();
                Days.Add(day);
            }
        }
        public void DisplayWeather()
        {
            Console.WriteLine(Days[0].Weather.currentTemperature);
           
        }
   
    }
}