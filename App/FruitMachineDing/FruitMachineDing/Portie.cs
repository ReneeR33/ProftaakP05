using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FruitMachineDing
{
    class Portie
    {
        List<string> portie = new List<string>();

        public List<string> AddToList(string Fruit)
        {
            portie.Add(Fruit);
            return portie;
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
