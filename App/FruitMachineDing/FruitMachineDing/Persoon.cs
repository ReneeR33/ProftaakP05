﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitMachineDing
{
    class Persoon
    {
        public List<string> porties = new List<string>();
        public Portie currentPortie { get; private set; } = new Portie();

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
            return (vitaminesBinnen > vitaminesNodig);
        }
    }
}
