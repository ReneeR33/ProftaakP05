using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitMachineDing
{
    class Persoon
    {
        public List<string> currentPortie;

        public Persoon()
        {
            currentPortie = new List<string>();
        }

        public List<string> AddToList(string portie)
        {
            currentPortie.Add(portie);
            return currentPortie;
        }
    }
}
