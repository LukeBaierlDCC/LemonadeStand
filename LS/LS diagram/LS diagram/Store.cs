using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LS_diagram
{
    public class Store
    {
        public void SellLemons(Player player, int qty)
        {
            if(player.Wallet.Cash >= (lemonPrice x 10))
            {
                for (int i = 0; i < qty; i++)
                {
                    Lemon lemon = new Lemon();
                    player.inventory.lemons.Add(lemon);
                }
            }
        }
    }
}