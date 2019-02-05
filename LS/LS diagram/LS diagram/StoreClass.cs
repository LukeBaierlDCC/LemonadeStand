using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LS_diagram
{
    public class StoreClass
    {
        public int lemonsToBuy;
        public int iceToBuy;
        public int sugarToBuy;
        public int cups;

        public StoreClass()
        {
            lemonsToBuy = 0;
            iceToBuy = 0;
            sugarToBuy = 0;
            cups = 0;

        }

        public void SelectionOfLemons(Player player)
        {
            int amount = 0;
            int userInput;

            double totalcost = 0;
            Console.WriteLine("How many lemons would you like to purchase? ");
            userInput = Int32.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    amount = 10;
                    totalcost = .60;
                    break;
                case 2:
                    amount = 30;
                    totalcost = 1.10;
                    break;
                case 3:
                    amount = 50;
                    totalcost = 1.40;
                    break;
            }

            lemonsToBuy = amount;
            double newTotal = player.cash - totalcost;
            player.cash = newTotal;
            Console.WriteLine("There's a total of " + player.cash + " left in your budget.");

        }
         
        public void SelectionOfIce(Player player)
        {
            int amount = 0;

            double totalcost = 0;
            Console.WriteLine("How many icecubes are you looking to buy? ");
            int userinput = Int32.Parse(Console.ReadLine());

            switch (userinput)
            {
                case 1:
                    amount = 100;
                    totalcost = .40;
                    break;
                case 2:
                    amount = 200;
                    totalcost = .75;
                    break;
                case 3:
                    amount = 300;
                    totalcost = 1.10;
                    break;
            }
            iceToBuy = amount;
            double newTotal = player.cash - totalcost;
            player.cash = newTotal;
            Console.WriteLine("There's a total of " + player.cash + " left in your budget.");

        }

        public void SelectionOfSugar(Player player)
        {
            int amount = 0;

            double totalcost = 0;
            Console.WriteLine("How many spoons of sugar would you like to buy? ");
            int userinput = Int32.Parse(Console.ReadLine());

            switch (userinput)
            {
                case 1:
                    amount = 4;
                    totalcost = .25;
                    break;
                case 2:
                    amount = 9;
                    totalcost = .40;
                    break;
                case 3:
                    amount = 12;
                    totalcost = .90;
                    break;
            }

            sugarToBuy = amount;
            double newTotal = player.cash - totalcost;
            player.cash = newTotal;
            Console.WriteLine("There's a total of " + player.cash + " left in your budget.");
        }

        public void SelectionOfCups(Player player)
        {
            int amount = 0;

            double totalcost = 0;
            Console.WriteLine("How many cups are you planning to buy? ");
            int userinput = Int32.Parse(Console.ReadLine());

            switch (userinput)
            {
                case 1:
                    amount = 30;
                    totalcost = .75;
                    break;
                case 2:
                    amount = 60;
                    totalcost = 1.45;
                    break;
                case 3:
                    amount = 120;
                    totalcost = 2.80;
                    break;
            }

            cups = amount;
            double newTotal = player.cash - totalcost;
            player.cash = newTotal;
            Console.WriteLine("There's a total of " + player.cash + " left in your budget.");
        }
    }
}