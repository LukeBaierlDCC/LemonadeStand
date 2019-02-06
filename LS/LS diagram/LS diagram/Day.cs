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
        public Recipe recipe;
        public CustomerType customers;
        public List <CustomerType> customersForDay;
        public double cupCounter;
        public int pitcher;

        public Day()
        {
            customersForDay = new List<CustomerType>();
            weather = new Weather();
        }
        public void RunDay(Inventory inventory, Recipe recipe, StoreClass store, Random num)
        { 
            store.DisplayStore();
            recipe.Recipe();
            GetPossibleCustomers();
            cupCounter = inventory.cups;
            RunThroughCustomers(inventory, recipe, store, num);
            UpdateEndOfDayVariables(recipe);
            UpdatePopularity(recipe);
            UpdateCustomerSatisfaction(recipe);
            DisplayDayResults(weather.GetActualTemperature, weather.weatherCondition, recipe, currentDay);
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
        public void GenerateCustomers()
        {
            for (int i = 0; i < possibleCustomers; i++)
            {
                CustomerType customer = new CustomerType();
                customersForDay.Add(customer);
            }
        }
        public void BuyLemonade()
        {
            for (int i = 0; i < customersForDay.Count; i++)
            {
                customersForDay[i].DoesBuy();
            }
        }

        public void customerSatisfaction()
        {
            for (int i = 0; i < possibleCustomers; i++)
            {
                CustomerType customer = new CustomerType();
                customersForDay.Add(customer);
            }
        }

        public void UpdatePopularity()
        {
            recipe.customerPopularity += Math.Round((payingCustomers / 10));
        }
        public void UpdateCustomerSatisfaction(Recipe recipe)
        {
            if ((recipe.customerSatisfaction + Math.Round((payingCustomers / 6)))<100)
            {
                recipe.customerSatisfaction += Math.Round((payingCustomers / 6));
            }
            else
            {
                recipe.customerSatisfaction = 100;
            }
        }
        public CustomerType CustomerType
        {
            get => default(CustomerType);
            set
            {
            }
        }
        public void UpdateInventory(Recipe recipe)
        {
            recipe.Inventory.lemons -= recipe.Recipe.lemonsToUse;
            recipe.Inventory.sugar -= recipe.Recipe.sugarToUse;
        }
        public void DisplayDayResults(double actualTemperature, string weatherCondition, Recipe recipe)
        {
            Console.WriteLine("Today's actual weather was " + actualTemperature + " and " + weatherCondition + ".");
            Console.WriteLine("");
            Console.WriteLine("You sold " + payingCustomers + " cups of lemonade to " + possibleCustomers + " customers.");
            Console.WriteLine("");
            Console.WriteLine("Your popularity has risen to " + recipe.Popularity + " and your customer satisfaction is at " + recipe.customerSatisfaction + "%.");
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
                DisplayDayResults(actualTemperature, weatherCondition, recipe, currentDay);
            }
        }
        public void UpdateEndOfDayVariables(Recipe recipe)
        {
            recipe.Inventory.Cups = cupCounter;
            recipe.Money += payingCustomers * recipe.Recipe.Price;
            recipe.Inventory.Ice = 0;
            recipe.Revenue += (payingCustomers * recipe.Recipe.Price);
        }
        public void RunThroughCustomers(Inventory inventory, Recipe recipe, Day day, Random num)
        {
            for (double j = 0; j < possibleCustomers; j++)
            {
                if (j == 0 || pitcher == 10 || pitcher == 20 || pitcher == 30 || pitcher == 40 || pitcher == 50 || pitcher == 60 || pitcher == 70 || pitcher == 80 || pitcher == 90 || pitcher == 100)
                {
                    UpdateInventory();
                    pitcher++;
                }
                if (cupCounter > 0 && inventory.lemons > recipe.lemonsToUse && inventory.sugar > recipe.sugarToUse && inventory.ice > recipe.iceToUse)
                {
                    Customers = new Customers(weather.GetActualTemperature, weather.weatherCondition, day, num);
                }
                else
                {
                    return;
                }
            }
        }
    }
}