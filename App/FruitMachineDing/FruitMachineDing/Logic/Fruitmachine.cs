using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitMachineDing
{
    class Fruitmachine
    {
        public enum disk
        {
            disk1 = 1,
            disk2,
            disk3,
        }
        private disk selectedDisk = disk.disk1;
        public disk SelectedDisk
        {
            get { return selectedDisk; }
        }
        
        public disk switchCuttingDisk()
        {
            int nextValue = (int)SelectedDisk + 1;
            if (nextValue > 3)
            {
                selectedDisk = (disk)nextValue;
            }
            return selectedDisk;
        }

        public void cutFruit()
        {
            //zet motor aan
        }
    }
}
