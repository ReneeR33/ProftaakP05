using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitMachineDing.desktop
{
    class FruitTab
    {
        public List<string> TotalVitamine(string connectionString, ListBox.ObjectCollection items)
        {
            List<string> fruitSoorten = new List<string>();
            List<string> vitamineLijst = new List<string>();
            foreach (string x in items)
            {
                if (!fruitSoorten.Contains(x))
                {
                    fruitSoorten.Add(x);
                }
            }
            foreach (var x in fruitSoorten)
            {
                //foreach (var y in GetVitamins(connectionString, x))
                //{
                //    if (!vitamineLijst.Contains(y))
                //    {
                //        vitamineLijst.Add(y);
                //    }
                //}
            }
            vitamineLijst.Sort();
            return vitamineLijst;
        }
    }
}
