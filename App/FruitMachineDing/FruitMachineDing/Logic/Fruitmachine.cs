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
        public bool stand = true;
        
        public int switchCuttingDisk(Serial serial)
        {
            if (disk == 3)
            {
                disk = 1;
            }
            else
            {
                disk++;
            }
            serial.SendMessage("SWITCH_DISK:" + Convert.ToString(disk));
            return disk;
        }

        public bool FruitCut(Serial serial)
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
