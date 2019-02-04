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