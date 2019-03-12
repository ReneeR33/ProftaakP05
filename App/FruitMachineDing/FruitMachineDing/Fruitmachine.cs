using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitMachineDing
{
    static class Fruitmachine
    {
        static int selectedDisk = 3;
        public static int swithCuttingDisk()
        {
            if (selectedDisk == 1)
            {
                selectedDisk = 2;
                return 2;
            }
            else if (selectedDisk == 2)
            {
                selectedDisk = 3;
                return 3;
            }
            else
            {
                selectedDisk = 1;
                return 1;
            }
        }
        public static void cutFruit()
        {
            //zet motor aan
        }
    }
}
