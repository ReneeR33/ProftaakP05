using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitMachineDing
{
    class Fruitmachine
    {

        public int disk = 1;
        
        public int switchCuttingDisk()
        {
            if (disk == 3)
            {
                disk = 1;
            }
            else
            {
                disk++;
            }
            return disk;
        }

        public void cutFruit()
        {
            //zet motor aan
        }
    }
}
