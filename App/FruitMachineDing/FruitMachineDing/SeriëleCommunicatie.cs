using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitMachineDing
{
    static class SeriëleCommunicatie
    {
        static bool hatchStatus = true;
        public static void ReadMessages()
        {
            //lees berichten
        }
        public static bool CheckHatch()
        {
            return hatchStatus;
        }
    }
}
