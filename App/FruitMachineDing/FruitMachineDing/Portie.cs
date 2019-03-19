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
        
<<<<<<< HEAD
        public static List<string> AddToList(string fruit)
        {
            portie.Add(fruit);
            return portie;
=======
        public void AddToList(string Fruit)
        {
            fruit.Add(Fruit);
>>>>>>> 97bd11f47a704738a32ba73ea1b35cc13635ec8c
        }
        public int CalculateCalories()
        {
            foreach(string Fruit in fruit)
            {
                //sql get calories 
//                calories += //sql geef calories van fruit met naam fruit
            }
            return calories;
        }
    }
}
