using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitMachineDing
{
    class Persoon
    {
        int vitaminesNodig;
        int vitaminesBinnen;
        string name;
        int age;
        int bodyType;
        public bool CheckVitamins()
        {
            //vitaminesNodig=sql check vitamines
            //sql check vitamines die nodig zijn
            if (vitaminesBinnen > vitaminesNodig)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
