using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitMachineDing
{
    class Portie
    {
        private int calories=0;
        List<string> portie = new List<string>();
        
        public List<string> AddToList(string Fruit)
        {
            portie.Add(Fruit);
            return portie;
        }

        public int CalculateCalories()
        {
            foreach(string fruit in portie)
            {
                //sql get calories 
                //calories += //sql geef calories van fruit met naam fruit 
            }
            return calories;
        }
        public List<string> RemoveFromList(string _fruit)
        {

                if (portie.Contains(_fruit))
                {
                    portie.RemoveAt(portie.IndexOf(_fruit));

                }
            return portie;
        }
    }
}
