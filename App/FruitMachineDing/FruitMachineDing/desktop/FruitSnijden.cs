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

        Serial serial = new Serial("COM3", 9600, new MessageBuilder('|', '%'));
        Fruitmachine fruitmachine = new Fruitmachine();
        Fruit Fruit = new Fruit();
        Persoon persoon = new Persoon();

        Portie portie1 = new Portie();
        List<string> portie = new List<string>();
        List<string> fruit = new List<string>();
        List<string> vitamines = new List<string>();
        List<string> personen = new List<string>();


        public FruitSnijden()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["FruitMachineDing.Properties.Settings.FruitDBConnectionString"].ConnectionString;
            this.FormClosed += new FormClosedEventHandler(FormFruitSnijden_FormClosed);
            //serial.Connect(); //alleen gebruiken als de arduino is aangesloten
        }
        private void FruitSnijden_Load(object sender, EventArgs e)
        {
            portie = portie1.GiveFruit(connectionString);
            po_fruitLbx.Items.AddRange(portie.ToArray());
            f_fruitList_lbx.Items.AddRange(portie.ToArray());
        }

        private void selectedFruitLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            vitamines = portie1.GiveVitamins(connectionString, f_fruitList_lbx.GetItemText(f_fruitList_lbx.SelectedItem));
            f_vitaminesSelectedFruit_lbx.Items.AddRange(vitamines.ToArray());
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
            personen = persoon.GivePersonNames(connectionString);
            portie = portie1.GiveFruit(connectionString);
            po_fruitLbx.Items.AddRange(portie.ToArray());
            f_fruitList_lbx.Items.AddRange(portie.ToArray());
            pe_namesLbx.Items.AddRange(personen.ToArray());
        }

        private void fruitInfoLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            fruitInfoLbl.Text = Fruit.GiveDescription(connectionString, f_fruitList_lbx.GetItemText(f_fruitList_lbx.SelectedItem));
        }

        private void SelectedFruitLbx2_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        // Portie Tab


        // Portie Tab Panel

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


        // Persoon Tab


        // Fruit Tab




        // Seriele communicatie

        void FormFruitSnijden_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Serial.Disconnect();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Hier word code uitgevoerd als arduino iets doorgestuurd heeft
            string[] messages = serial.ReadMessages();
            if (messages != null && messages.Length != 0)
            {
                foreach (string message in messages)
                {
                    if (message.StartsWith("Fingerprint_Detected:"))
                    {
                        int id;
                        if (Int32.TryParse(message.Substring(message.IndexOf(":") + 1), out id))
                        {
                            // Doe iets met id, (bijv. kijk in database bij welke persoon dit id hoort en laad de juiste gegevens)
                        }
                    }
                    // Else if message =... etc. 
                }
            }
        }

        private void pe_namesLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            pe_leeftijdInputLbl.Text = Convert.ToString(persoon.GiveAge(connectionString, pe_namesLbx.GetItemText(pe_namesLbx.SelectedIndex)));
            pe_naamInputLbl.Text = pe_namesLbx.GetItemText(pe_namesLbx.SelectedItem);
        }
    }
}
