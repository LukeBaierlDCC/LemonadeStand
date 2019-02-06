using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LS_diagram
{
    public class Player
    {
        string name;
        public double money;
        public Wallet wallet;

        //constructor
        public Player()
        {

            wallet = new Wallet();
            
        }
        public Recipe Recipe
        {
            //get => default(Recipe);
            set
            {
            }
        }

        public Wallet Wallet
        {
            //get => default(Wallet);
            set
            {
            }
        }

        public Inventory Inventory
        {
            get => default(Inventory);
            set
            {
            }
        }
    }
}