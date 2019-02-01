using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LS_diagram
{
    public class Game
    {
        public Day day;

        public Player player;

        public StoreClass store;

        public Rules rules;

        public Game()
        {
            day = new Day();

            player = new Player();

            store = new StoreClass();

            rules = new Rules();
        }
   
    }
}