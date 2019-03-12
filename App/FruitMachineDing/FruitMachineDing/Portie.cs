using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitMachineDing
{
    static class Portie
    {
        static int calories=0;
        public static List<string> portie = new List<string>();
        
        public static void AddToList(string fruit)
        {
            portie.Add(fruit);
        }
        public static int CalculateCalories()
        {
            foreach(string fruit in portie)
            {

//                calories += //sql geef calories van fruit met naam fruit
            }
            return calories;
        }
    }
}
