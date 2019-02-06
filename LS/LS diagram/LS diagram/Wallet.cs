using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LS_diagram
{
    public class Wallet
    {
        public double money = 10.00;
        bool bankrupt;
        double completeTransaction;
        double CostOfProduct;
        public void DisplayBalance()
        {
            Console.WriteLine("Your total budget is ${0}", moneyInWallet);
        }

        public bool checkIfBankrupt(double CostOfProduct)
        {
            if (moneyInWallet < CostOfProduct)
            {
                bankrupt = true;
                Console.WriteLine("You're too low on funds.");
                Console.ReadLine();
            }
            return bankrupt;

        }
        public double buyProduct(double costOfProduct)
        {
            double earnings;
            double startingFunds = 10;
            earnings = moneyInWallet - startingFunds;
            Console.WriteLine("You made {0} this week. Play again and try to earn more.", earnings);
        }
    }
}