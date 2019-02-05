using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LS_diagram
{
    public class Player
    {
        public Player Player
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
            get => default(Wallet);
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