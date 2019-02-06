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
        public Player player;
        public CustomerType customers;
        public List <CustomerType> customersForDay;
        public double cupCounter;
        public double temperature;
        public int pitcher;

        public Day()
        {
            player = new Player();
            customersForDay = new List<CustomerType>();
            weather = new Weather();
        }
        public void RunDay(Inventory inventory, Recipe recipe, StoreClass store)
        { 
            store.DisplayStore();
            recipe.SetRecipe();
            GetPossibleCustomers();
            cupCounter = inventory.cups;
            RunThroughCustomers(inventory, recipe);
            UpdateEndOfDayVariables(recipe);
            UpdatePopularity(recipe);
            UpdateCustomerSatisfaction(recipe);
            DisplayDayResults(weather.GetActualTemperature, weather.weatherCondition, recipe);
        }
        private class Temperature temperature()
        {
            
        }
        private void RunThroughCustomers(Inventory inventory, Recipe recipe)
        {
            throw new NotImplementedException();
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

        public void UpdatePopularity(Recipe recipe)
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
            recipe.inventory.lemons -= recipe.lemonsToUse;
            recipe.inventory.sugar -= recipe.sugarToUse;
        }
        public void DisplayDayResults(double actualTemperature, string weatherCondition, Recipe recipe)
        {
            Console.WriteLine("Today's actual weather was " + actualTemperature + " and " + weatherCondition + ".");
            Console.WriteLine("");
            Console.WriteLine("You sold " + payingCustomers + " cups of lemonade to " + possibleCustomers + " customers.");
            Console.WriteLine("");
            Console.WriteLine("Your popularity has risen to " + recipe.popularity + " and your customer satisfaction is at " + recipe.customerSatisfaction + "%.");
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
                DisplayDayResults(actualTemperature, weatherCondition, recipe);
            }
        }
        public void UpdateEndOfDayVariables(Recipe recipe)
        {
            recipe.inventory.cups = cupCounter;
            player.wallet.money += payingCustomers * recipe.price;
            recipe.inventory.ice = 0;
            recipe.revenue += (payingCustomers * recipe.price);
        }
        public void RunThroughCustomers(Inventory inventory, Recipe recipe, Random num)
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
                    Customers = new Customers(weather.GetActualTemperature, weather.weatherCondition);
                }
                else
                {
                    return;
                }
            }
        }
    }
}