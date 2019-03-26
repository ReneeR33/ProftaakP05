using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace FruitMachineDing
{
    public partial class FruitSnijden : Form
    {
        public string connectionString { get; private set; }
        Portie portie1 = new Portie();

        List<string> portie = new List<string>();
        //Van de klassen moet je eerst een object aanmaken! 
        //EN Go fuck yourself
        Fruitmachine fruitmachine = new Fruitmachine();

        Persoon persoon = new Persoon();

        public FruitSnijden()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["FruitMachineDing.Properties.Settings.FruitDBConnectionString"].ConnectionString;
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
            portie = portie1.AddToList(FruitLbx.GetItemText(FruitLbx.SelectedIndex));
            selectedFruitLbx.Items.Clear();
            foreach (string fruit in portie)
            {
                selectedFruitLbx.Items.Add(fruit);
            }
        }
    }
}
