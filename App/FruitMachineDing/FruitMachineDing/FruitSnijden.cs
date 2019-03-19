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
        List<string> portie = new List<string>();
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
            snijschijfInputLbl.Text = Convert.ToString(Fruitmachine.swithCuttingDisk());

        }

        private void BevestigingPanel_VisibleChanged(object sender, EventArgs e)
        {
            snijschijfInputLbl.Text = Convert.ToString(Fruitmachine.swithCuttingDisk());
        }

        private void selectedFruitLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Portie.CalculateCalories();
        }

        private void FruitLbx_VisibleChanged(object sender, EventArgs e)
        {
            Portie.AddToList(FruitLbx.GetItemText(FruitLbx.SelectedIndex));
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
            Portie.AddToList(FruitLbx.GetItemText(FruitLbx.SelectedIndex));
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
