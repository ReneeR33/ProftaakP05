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
        Portie portie1 = new Portie();
        List<string> portie = new List<string>();
        List<string> fruit = new List<string>();
        List<string> vitamines = new List<string>();


        public FruitSnijden()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["FruitMachineDing.Properties.Settings.FruitDBConnectionString"].ConnectionString;
            this.FormClosed += new FormClosedEventHandler(FormFruitSnijden_FormClosed);
            //serial.Connect(); //alleen gebruiken als de arduino is aangesloten
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
            vitamines = portie1.GiveVitamins(connectionString, f_fruitList.GetItemText(f_fruitList.SelectedItem));
            f_vitaminesSelectedFruit.Items.AddRange(vitamines.ToArray());
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
            f_fruitList.Items.AddRange(portie.ToArray());
        }

        private void fruitInfoLbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectedFruitLbx2_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
        void FormFruitSnijden_FormClosed(object sender, FormClosedEventArgs e)
        {
            //serial.Disconnect();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //hier word code uitgevoerd als arduino iets doorgestuurd heeft
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
                            //doe iets met id, (bijv. kijk in database bij welke persoon dit id hoort en laad de juiste gegevens)
                        }
                    }
                    //else if message =... etc. 
                }
            }
        }
    }
}
