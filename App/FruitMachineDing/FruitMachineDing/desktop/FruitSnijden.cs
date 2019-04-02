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
            portie = portie1.RemoveFromList(Convert.ToString(po_selectedFruitLbx.GetItemText(po_selectedFruitLbx.SelectedItem)));
            po_selectedFruitLbx.Items.Clear();
            po_selectedFruitLbx.Items.AddRange(portie.ToArray());
        }

        private void FruitLbx_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            portie = portie1.AddToList(po_fruitLbx.GetItemText(po_fruitLbx.SelectedItem));
            po_selectedFruitLbx.Items.Clear();
            po_selectedFruitLbx.Items.AddRange(portie.ToArray());
        }

        private void FruitSnijden_Load(object sender, EventArgs e)
        {
            portie = portie1.GiveFruit(connectionString);
            po_fruitLbx.Items.AddRange(portie.ToArray());
            f_fruitInfoLbx.Items.AddRange(portie.ToArray());
        }

        private void fruitInfoLbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectedFruitLbx2_SelectedIndexChanged(object sender, EventArgs e)
        {
            vitamines = portie1.GiveVitamins(connectionString, f_fruitInfoLbx.GetItemText(f_fruitInfoLbx.SelectedItem));
            f_SelectedFruitLbx.Items.AddRange(vitamines.ToArray());

        }
    }
}
