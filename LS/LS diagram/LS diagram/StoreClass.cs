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
            Console.WriteLine("There is " + player.cash + " left in your wallet.");

        }
                
    }
}