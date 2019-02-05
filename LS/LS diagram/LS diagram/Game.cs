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

        public int currentDay;

        public double daysPlaying;

        public Game()
        {
            Random num = new Random();

            DisplayRules();

            Console.Clear();

            lemonadeStandOne = new LemonadeStand();

            Days = new List<Day>();

            player = new Player();

            store = new StoreClass();

            rules = new Rules();

            currentDay = 1;

            RunGameDays(lemonadeStandOne.inventory, lemonadeStandOne, store, Day, num);

            DisplayEndGame(lemonadeStandOne);
        }

        private void DisplayRules()
        {

            bool isNumber = double.TryParse(Console.ReadLine(), out daysPlaying);
            switch (daysPlaying)
            {
                case 7:
                    break;
                default:
                    Console.Clear();
                    DisplayRules();
                    break;

            }
        
        public void GenerateDays(int numberOfDays)
        {
            for (int i = 0; i < numberOfDays; i++)
            {
                Day day = new Day();
                Days.Add(day);
                day.payingCustomers = 0;
                day.RunDay(inventory, lemonadeStand, store, day, currentDay, num);
                this.currentDay += 1;
            }
        }
        public void DisplayWeather()
        {
            Console.WriteLine(Days[0].Weather.currentTemperature);
           
        }

        public void DisplayEndGame(LemonadeStand lemonadeStand)
        {
            Console.WriteLine("Moving on to day " + daysPlaying + " and you made $" + lemonadeStand.money +".");
        }
   
    }
}