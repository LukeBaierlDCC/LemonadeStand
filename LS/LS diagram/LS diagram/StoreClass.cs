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
            Console.WriteLine("Type 10 if you want to buy 10 lemons for .60.");
            Console.WriteLine("Type 30 if you want to buy 30 lemons for 1.10.");
            Console.WriteLine("Type 50 if you want to buy 50 lemons for 1.40.");
            userInput = Int32.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 10:
                    amount = 10;
                    totalcost = .60;
                    break;
                case 30:
                    amount = 30;
                    totalcost = 1.10;
                    break;
                case 50:
                    amount = 50;
                    totalcost = 1.40;
                    break;
                default:
                    Console.WriteLine("Wrong input, dummy!");
                    SelectionOfLemons(player);
                    break;
            }

            lemonsToBuy = amount;
            double newTotal = player.money - totalcost;
            player.money = newTotal;
            Console.WriteLine("There's a total of " + player.money + " left in your budget.");

        }
         
        public void SelectionOfIce(Player player)
        {
            int amount = 0;

            double totalcost = 0;
            Console.WriteLine("How many icecubes are you looking to buy? ");
            Console.WriteLine("Type 100 if you want to buy 100 icecubes for .40.");
            Console.WriteLine("Type 200 if you want to buy 200 icecubes for .75.");
            Console.WriteLine("Type 300 if you want to buy 300 icecubes for 1.10.");
            int userinput = Int32.Parse(Console.ReadLine());

            switch (userinput)
            {
                case 100:
                    amount = 100;
                    totalcost = .40;
                    break;
                case 200:
                    amount = 200;
                    totalcost = .75;
                    break;
                case 300:
                    amount = 300;
                    totalcost = 1.10;
                    break;
                default:
                    Console.WriteLine("Wrong input, dude!");
                    SelectionOfIce(player);
                    break;
            }
            iceToBuy = amount;
            double newTotal = player.money - totalcost;
            player.money = newTotal;
            Console.WriteLine("There's a total of " + player.money + " left in your budget.");

        }

        public void SelectionOfSugar(Player player)
        {
            int amount = 0;

            double totalcost = 0;
            Console.WriteLine("How many spoons of sugar would you like to buy? ");
            Console.WriteLine("Type 4 if you want to buy 4 cups of sugar for .25.");
            Console.WriteLine("Type 9 if you want to buy 9 cups of sugar for .60.");
            Console.WriteLine("Type 12 if you want to buy 12 cups of sugar for 1.05.");
            int userinput = Int32.Parse(Console.ReadLine());

            switch (userinput)
            {
                case 4:
                    amount = 4;
                    totalcost = .25;
                    break;
                case 9:
                    amount = 9;
                    totalcost = .60;
                    break;
                case 12:
                    amount = 12;
                    totalcost = 1.05;
                    break;
                default:
                    Console.WriteLine("Wrong input, dummy!");
                    SelectionOfSugar(player);
                    break;
            }

            sugarToBuy = amount;
            double newTotal = player.money - totalcost;
            player.money = newTotal;
            Console.WriteLine("There's a total of " + player.money + " left in your budget.");
        }

        public void SelectionOfCups(Player player)
        {
            int amount = 0;

            double totalcost = 0;
            Console.WriteLine("How many cups are you planning to buy? ");
            Console.WriteLine("Type 30 to buy 30 cups for .75.");
            Console.WriteLine("Type 60 to buy 60 cups for 1.45.");
            Console.WriteLine("Type 120 to buy 120 cups for 2.80.");
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
                default:
                    Console.WriteLine("Wrong input, dummy! Thank goodness you didn't type flamingo...");
                    SelectionOfCups(player);
                    break;
            }

            cups = amount;
            double newTotal = player.money - totalcost;
            player.money = newTotal;
            Console.WriteLine("There's a total of " + player.money + " left in your budget.");
        }
        public void DisplayStore()
        {

        }
    }
}