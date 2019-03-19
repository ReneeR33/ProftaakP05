using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitMachineDing
{
    public partial class FruitSnijden : Form
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
        List<string> portie = new List<string>();
>>>>>>> 73dc505dee249d0655ea1c1566273e8d30095dc5
=======
        List<string> portie = new List<string>();
>>>>>>> 73dc505dee249d0655ea1c1566273e8d30095dc5
=======
        //Van de klassen moet je eerst een object aanmaken! 
        //EN GEEN STATIC GEBRUIKEN
        Fruitmachine fruitmachine = new Fruitmachine();
        Persoon persoon = new Persoon();

>>>>>>> 97bd11f47a704738a32ba73ea1b35cc13635ec8c
        public FruitSnijden()
        {
            InitializeComponent();
        }

        private void BevestigKnop_Click(object sender, EventArgs e)
        {
            BevestigingPanel.Visible = true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            BevestigingPanel.Visible = false;
        }

        private void snijschijfBtn_Click(object sender, EventArgs e)
        {
            snijschijfInputLbl.Text = fruitmachine.switchCuttingDisk().ToString();

        }

        private void BevestigingPanel_VisibleChanged(object sender, EventArgs e)
        {
            snijschijfInputLbl.Text = fruitmachine.switchCuttingDisk().ToString();
        }

        private void selectedFruitLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            persoon.currentPortie.CalculateCalories();
        }

        private void FruitLbx_VisibleChanged(object sender, EventArgs e)
        {
            persoon.currentPortie.AddToList(FruitLbx.GetItemText(FruitLbx.SelectedIndex));
        }

        private void persoonLbl_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            FruitLbx.Items.Add(Convert.ToString(ran.Next(0, 100)));
        }

        private void selectedFruit_Click(object sender, EventArgs e)
        {
            //haal eruit vergeeet  niet list in portie
        }

        private void FruitLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            persoon.currentPortie.AddToList(FruitLbx.GetItemText(FruitLbx.SelectedIndex));
        }

        private void BevestigingPanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            portie = Portie.AddToList(FruitLbx.GetItemText(FruitLbx.SelectedIndex));
            selectedFruitLbx.Items.Clear();
            foreach (string fruit in portie)
            {
                selectedFruitLbx.Items.Add(fruit);
            }
        }
    }
}
