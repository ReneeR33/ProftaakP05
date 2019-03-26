using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitMachineDing
{
    class Fruitmachine
    {
        //Geef de disks een naam, en gebruik deze in plaats van een int
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
            //Zeg Nick wat is dit? 

            //if (selectedDisk == 1)
            //{
            //    selectedDisk = 2;
            //    return 2;
            //}
            //else if (selectedDisk == 2)
            //{
            //    selectedDisk = 3;
            //    return 3;
            //}
            //else
            //{
            //    selectedDisk = 1;
            //    return 1;
            //}
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
