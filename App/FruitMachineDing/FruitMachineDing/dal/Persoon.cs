using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace FruitMachineDing
{
    class Persoon
    {

        public List<string> porties = new List<string>();

        public Portie currentPortie { get; private set; } = new Portie();

        string name;
        int age;
    }
}
