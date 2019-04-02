using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace FruitMachineDing
{
    public partial class FruitSnijden : Form
    {
        public SqlConnection connectionString { get; private set; }

        Fruitmachine fruitmachine = new Fruitmachine();
        Portie portie1 = new Portie();
        List<string> portie = new List<string>();
        List<string> fruit = new List<string>();

        //Waar is de persoon klasse?
        //NICK EN MAJKOL GA AAN HET WERK!!!!!!!!!!!!!!
        //NICK EN MAJKOL GA AAN HET WERK!!!!!!!!!!!!!!
        //NICK EN MAJKOL GA AAN HET WERK!!!!!!!!!!!!!!
        //NICK EN MAJKOL GA AAN HET WERK!!!!!!!!!!!!!!
        //NICK EN MAJKOL GA AAN HET WERK!!!!!!!!!!!!!!
        //NICK EN MAJKOL GA AAN HET WERK!!!!!!!!!!!!!!
        //NICK EN MAJKOL GA AAN HET WERK!!!!!!!!!!!!!!
        //NICK EN MAJKOL GA AAN HET WERK!!!!!!!!!!!!!!
        //NICK EN MAJKOL GA AAN HET WERK!!!!!!!!!!!!!!
        //NICK EN MAJKOL GA AAN HET WERK!!!!!!!!!!!!!!
        //NICK EN MAJKOL GA AAN HET WERK!!!!!!!!!!!!!!
        //NICK EN MAJKOL GA AAN HET WERK!!!!!!!!!!!!!!
        //NICK EN MAJKOL GA AAN HET WERK!!!!!!!!!!!!!!
        //NICK EN MAJKOL GA AAN HET WERK!!!!!!!!!!!!!!
        //NICK EN MAJKOL GA AAN HET WERK!!!!!!!!!!!!!!
        //NICK EN MAJKOL GA AAN HET WERK!!!!!!!!!!!!!!
        //NICK EN MAJKOL GA AAN HET WERK!!!!!!!!!!!!!!

        public FruitSnijden()
        {
            InitializeComponent();
            //connectionString = ConfigurationManager.ConnectionStrings["FruitMachineDing.Properties.Settings.FruitDBConnectionString"].ConnectionString;
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
            portie1.GiveFruit(connectionString);
        }
    }
}
