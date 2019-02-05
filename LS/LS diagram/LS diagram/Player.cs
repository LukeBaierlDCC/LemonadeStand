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
        public Player(string Name)
        {
            name = Name;
            money = 10.00;
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