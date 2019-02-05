using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LS_diagram
{
    public class Day
    {
        public double possibleCustomers;
        public double payingCustomers;
        public Weather weather;
        public CustomerType customers;
        public double cupCounter;
        public int pitcher;

        public Day()
        {
            weather = new Weather();
        }
        public void RunDay(Inventory inventory, LemonadeStand lemonadeStand, StoreClass store, Day day, int currentDay, Random num)
        {
            weather = new Weather();
            store.DisplayStore(inventory, lemonadeStand, weather, currentDay);
            lemonadeStand.SetRecipe();
            GetPossibleCustomers();
            this.cupCounter = inventory.cups;
            RunThroughCustomers(inventory, lemonadeStand, store, day, num);
            UpdateEndOfDayVariables(lemonadeStand);
            UpdatePopularity(lemonadeStand);
            UpdateCustomerSatisfaction(lemonadeStand);
            DisplayDayResults(weather.GetActualTemperature, weather.weatherCondition, lemonadeStand, currentDay);
        }
        public Weather Weather
        {
            get => default(Weather);
            set
            {
            }
        }
        public void GetPossibleCustomers()
        {
            Random rnd = new Random();
            possibleCustomers = rnd.Next(85, 120);
        }
        public void UpdatePopularity(LemonadeStand lemonadeStand)
        {
            lemonadeStand.popularity += Math.Round((payingCustomers / 10));
        }
        public void UpdateCustomerSatisfaction(LemonadeStand lemonadeStand)
        {
            if ((lemonadeStand.customerSatisfaction + Math.Round((payingCustomers / 6)))<100)
            {
                lemonadeStand.customerSatisfaction += Math.Round((payingCustomers / 6));
            }
            else
            {
                lemonadeStand.customerSatisfaction = 100;
            }
        }
        public CustomerType CustomerType
        {
            get => default(CustomerType);
            set
            {
            }
        }
        public void UpdateInventory(LemonadeStand lemonadeStand)
        {
            lemonadeStand.inventory.lemons -= lemonadeStand.Recipe.lemonsToUse;
            lemonadeStand.inventory.sugar -= lemonadeStand.Recipe.sugarToUse;
        }
        public void DisplayDayResults(double actualTemperature, string weatherCondition, LemonadeStand lemonadeStand)
        {
            Console.WriteLine("Today's actual weather was " + actualTemperature + " and " + weatherCondition + ".");
            Console.WriteLine("");
            Console.WriteLine("You sold " + payingCustomers + " cups of lemonade to " + possibleCustomers + " customers.");
            Console.WriteLine("");
            Console.WriteLine("Your popularity has risen to " + lemonadeStand.popularity + " and your customer satisfaction is at " + lemonadeStand.customerSatisfaction + "%.");
            Console.WriteLine("Press enter so we can get back to selling.");
            Console.WriteLine("");
            Console.WriteLine("A new day of selling lemonade.");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                return;
            }
            else
            {
                DisplayDayResults(actualTemperature, weatherCondition, lemonadeStand, currentDay);
            }
        }
        public void UpdateEndOfDayVariables(LemonadeStand lemonadeStand)
        {
            lemonadeStand.Inventory.Cups = cupCounter;
            lemonadeStand.Money += payingCustomers * lemonadeStand.Recipe.Price;
            lemonadeStand.Inventory.Ice = 0;
            lemonadeStand.Revenue += (payingCustomers * lemonadeStand.Recipe.Price);
        }
        public void RunThroughCustomers(Inventory inventory, LemonadeStand lemonadeStand, StoreClass store, Day day, Random num)
        {
            for (double j = 0; j < possibleCustomers; j++)
            {
                if (j == 0 || pitcher == 10 || pitcher == 20 || pitcher == 30 || pitcher == 40 || pitcher == 50 || pitcher == 60 || pitcher == 70 || pitcher == 80 || pitcher == 90 || pitcher == 100)
                {
                    UpdateInventory(lemonadeStand);
                    pitcher++;
                }
                if (cupCounter > 0 && inventory.lemons > lemonadeStand.Recipe.lemonsToUse && inventory.sugar > lemonadeStand.Recipe.sugarToUse && inventory.ice > lemonadeStand.Recipe.iceToUse)
                {

                }
            }
        }
    }
}