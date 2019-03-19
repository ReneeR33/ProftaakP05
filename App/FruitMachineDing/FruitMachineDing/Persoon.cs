using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitMachineDing
{
    class Persoon
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
        public List<string> porties = new List<string>();
        public Portie currentPortie { get; private set; } = new Portie();

>>>>>>> 97bd11f47a704738a32ba73ea1b35cc13635ec8c
=======
        public List<string> porties = new List<string>();
        public Portie currentPortie { get; private set; } = new Portie();

>>>>>>> 73dc505dee249d0655ea1c1566273e8d30095dc5
=======
        public List<string> porties = new List<string>();
        public Portie currentPortie { get; private set; } = new Portie();

>>>>>>> 73dc505dee249d0655ea1c1566273e8d30095dc5
        int vitaminesNodig;
        int vitaminesBinnen;
        int calorienBinnen;
        int calorienNodig;
        string name;
        int age;
        int bodyType;
        public bool CheckCalories()
        {
            //calorienNodig= sql check calorien
            //calorienBinnen = sql check calorien die nodig zijn
            if (calorienBinnen> calorienNodig)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckVitamins()
        {
<<<<<<< HEAD
            //vitaminesBinnen=sql check vitamines
            //vitaminesNodig=sql check vitamines die nodig zijn
            if (vitaminesBinnen > vitaminesNodig)
            {
                return true;
            }
            else
            {
                return false;
            }
=======
            //vitaminesNodig=sql check vitamines
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            //sql check vitamines die nodig zijn
            if (vitaminesBinnen > vitaminesNodig)
            {
                return true;
            }
            else
            {
                return false;
            }
=======
=======
>>>>>>> 73dc505dee249d0655ea1c1566273e8d30095dc5
=======
>>>>>>> 73dc505dee249d0655ea1c1566273e8d30095dc5
            ////sql check vitamines die nodig zijn
            //if (vitaminesBinnen > vitaminesNodig)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return (vitaminesBinnen > vitaminesNodig);

>>>>>>> 97bd11f47a704738a32ba73ea1b35cc13635ec8c
        }
    }
}
