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

        public bool FruitCut(Serial serial, bool stand)
        {
            if (stand)
            {
                serial.SendMessage("CUT_START");
            }
            else
            {
                serial.SendMessage("CUT_STOP");
            }
            return !stand;
        }
    }
}
