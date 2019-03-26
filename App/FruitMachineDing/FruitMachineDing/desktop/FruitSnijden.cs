using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace FruitMachineDing
{
    public partial class FruitSnijden : Form
    {
        Fruitmachine fruitmachine = new Fruitmachine();
        Persoon persoon = new Persoon();
        Portie portie1 = new Portie();

        List<string> portie = new List<string>();
        public string connectionString { get; private set; }



        public FruitSnijden()
        {
            InitializeComponent();
            FruitLbx.Items.Add("appel");
            FruitLbx.Items.Add("druif");
            FruitLbx.Items.Add("peer");
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

        private void FruitLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            persoon.currentPortie.AddToList(FruitLbx.GetItemText(FruitLbx.SelectedIndex));
        }

        private void selectedFruitLbx_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            selectedFruitLbx.DataSource = null;
            portie = portie1.RemoveFromList(Convert.ToString(selectedFruitLbx.GetItemText(selectedFruitLbx.SelectedItem)));
            selectedFruitLbx.Items.Clear();
            selectedFruitLbx.DataSource = portie;
        }

        private void FruitLbx_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            selectedFruitLbx.DataSource = null;
            portie = portie1.AddToList(FruitLbx.GetItemText(FruitLbx.SelectedItem));
            selectedFruitLbx.Items.Clear();
            selectedFruitLbx.Items.AddRange(portie.ToArray());
        }
    }
}
