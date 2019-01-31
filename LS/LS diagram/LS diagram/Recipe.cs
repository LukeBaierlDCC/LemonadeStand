using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LS_diagram
{
    public class Recipe
    {
        private int Cups;
        private int Ice;
        private int Lemons;
        private int Sugar;

        public Inventory Inventory
        {
            get => default(Inventory);
            set
            {
            }
        }

        public void GetSugar()
        {
            throw new System.NotImplementedException();
        }

        public void GetIce()
        {
            throw new System.NotImplementedException();
        }

        public void GetLemons()
        {
            throw new System.NotImplementedException();
        }

        public void GetCups()
        {
            throw new System.NotImplementedException();
        }
    }
}