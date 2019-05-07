using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitMachineDing.desktop
{
    class PortieTab
    {
        List<string> portie = new List<string>();

        public List<string> AddToList(string fruit)
        {
            portie.Add(fruit);
            return portie;
        }
        public List<string> RemoveFromList(string fruit)
        {
            if (portie.Contains(fruit))
            {
                portie.RemoveAt(portie.IndexOf(fruit));
            }
            return portie;
        }
    }
}
