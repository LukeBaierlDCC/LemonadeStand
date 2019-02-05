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

        public CustomerType CustomerType
        {
            get => default(CustomerType);
            set
            {
            }
        }
    }
}