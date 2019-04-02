using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace FruitMachineDing
{
    public partial class FruitSnijden : Form
    {
        public string connectionString;

        Fruitmachine fruitmachine = new Fruitmachine();
        Portie portie1 = new Portie();
        List<string> portie = new List<string>();
        List<string> fruit = new List<string>();
        List<string> vitamines = new List<string>();


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

        }

        private void selectedFruitLbx_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            portie = portie1.RemoveFromList(Convert.ToString(selectedFruitLbx.GetItemText(selectedFruitLbx.SelectedItem)));
            selectedFruitLbx.Items.Clear();
            selectedFruitLbx.Items.AddRange(portie.ToArray());
        }

        private void FruitLbx_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            portie = portie1.AddToList(FruitLbx.GetItemText(FruitLbx.SelectedItem));
            selectedFruitLbx.Items.Clear();
            selectedFruitLbx.Items.AddRange(portie.ToArray());
        }

        private void FruitSnijden_Load(object sender, EventArgs e)
        {
            portie = portie1.GiveFruit(connectionString);
            FruitLbx.Items.AddRange(portie.ToArray());
            fruitInfoLbx.Items.Add("appel");
        }

        private void fruitInfoLbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectedFruitLbx2_SelectedIndexChanged(object sender, EventArgs e)
        {
            vitamines = portie1.GiveVitamins(connectionString, fruitInfoLbx.GetItemText(fruitInfoLbx.SelectedItem));
            SelectedFruitLbx2.Items.AddRange(vitamines.ToArray());

        }
    }
}
