using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LS_diagram
{
    public class Recipe
    {
        internal readonly double customerSatisfaction;

        //private int Cups;
        //private int Ice;
        //private int Lemons;
        //private int Sugar;
        public double lemonsToUse = 4;
        public double sugarToUse = 4;
        public double iceToUse = 4;
        public double price = 0.25;
        internal Inventory inventory;
        internal int Money;

        public Recipe()
        {
            //inventory = new Inventory.Inventory()
            return;
        }

        public void SetRecipe()
        {
            Console.WriteLine("How many lemons?");
            lemonsToUse = double.Parse(Console.ReadLine());
            Console.WriteLine("How many cups of sugar?");
            sugarToUse = double.Parse(Console.ReadLine());
            Console.WriteLine("How much ice?");
            iceToUse = double.Parse(Console.ReadLine());
        }

        public Inventory
        {
            //recipe = new Recipe();
            return;
        }

    }
}