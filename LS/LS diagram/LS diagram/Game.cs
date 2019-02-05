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

        Rules rules;

        public int currentDay;

        public double daysPlaying;

        public Recipe recipe;

        public Game()
        {
            recipe = new Recipe();
            Random num = new Random();

            DisplayRules();

            Console.Clear();

            //lemonadeStandOne = new LemonadeStand();

            Days = new List<Day>();

            Console.WriteLine("What is your name?");

            player = new Player(Console.ReadLine());

            store = new StoreClass();

            rules = new Rules();

            currentDay = 1;

            Days[0].RunDay(player.Inventory, recipe, store, num);

            //RunGameDays(lemonadeStandOne.inventory, lemonadeStandOne, store, Day, num);

            //DisplayEndGame(lemonadeStandOne);
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
        }
        
        public void GenerateDays(int numberOfDays)
        {
            for (int i = 0; i < numberOfDays; i++)
            {
                Day day = new Day();
                day.payingCustomers = 0;
                Days.Add(day);
                day.RunDay(player.Inventory, store, day, currentDay, num);
                //this.currentDay += 1;
            }
        }
        public void DisplayWeather()
        {
            Console.WriteLine(Days[0].Weather.currentTemperature);
           
        }

        public void DisplayEndGame()
        {
            Console.WriteLine("Moving on to day " + daysPlaying + " and you made $" + player.money +".");
        }
   
    }
}