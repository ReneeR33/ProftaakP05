using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitMachineDing
{
    class Portie
    {
        //GEEN STATIC GEBRUIKEN GVD NICK
        private int calories=0;
        public List<string> fruit = new List<string>();
        
        public void AddToList(string Fruit)
        {
            fruit.Add(Fruit);
        }

        public int CalculateCalories()
        {
            foreach(string Fruit in fruit)
            {
                //sql get calories 
                //calories += //sql geef calories van fruit met naam fruit
            }
            return calories;
        }
    }
}
