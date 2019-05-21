﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace FruitMachineDing
{
    public partial class FruitSnijden : Form
    {
        public string connectionString;

        Serial serial = new Serial("COM7", 9600, new MessageBuilder('|', '&'));
        Fruitmachine fruitmachine = new Fruitmachine();
        SQL.Fruit Fruit = new SQL.Fruit();
        SQL.Persoon Persoon = new SQL.Persoon();
        SQL.Portie Portie = new SQL.Portie();
        SQL.Vitamines Vitamines = new SQL.Vitamines();
        desktop.PortieTab PortieTab = new desktop.PortieTab();
        desktop.PersoonTab PersoonTab = new desktop.PersoonTab();
        desktop.FruitTab FruitTab = new desktop.FruitTab();
        List<string> portie = new List<string>();
        List<string> fruit = new List<string>();
        List<string> personen = new List<string>();


        public FruitSnijden()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["FruitMachineDing.Properties.Settings.FruitDBConnectionString"].ConnectionString;
            this.FormClosed += new FormClosedEventHandler(FormFruitSnijden_FormClosed);
            po_persoonLbl.Text = "";
            serial.Connect();
        }

        private void FruitSnijden_Load(object sender, EventArgs e)
        {
            personen = Persoon.GivePersonNames(connectionString);
            portie = Fruit.GiveFruit(connectionString);
            po_fruitLbx.Items.AddRange(portie.ToArray());
            f_fruitList_lbx.Items.AddRange(portie.ToArray());
            pe_namesLbx.Items.AddRange(personen.ToArray());

            po_fruitLbx.SetSelected(0, true);
            pe_namesLbx.SetSelected(0, true);
            f_fruitList_lbx.SetSelected(0, true);
        }

        // Portie Tab

        private void FruitLbx_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Adding to the next listbox
            portie = PortieTab.AddToList(po_fruitLbx.GetItemText(po_fruitLbx.SelectedItem));
            po_selectedFruitLbx.Items.Clear();
            po_selectedFruitLbx.Items.AddRange(portie.ToArray());
            po_selectedFruitLbx.SetSelected(po_selectedFruitLbx.Items.Count-1, true);
            // Adding Vitamines to the collective/total Vitamine listbox
            po_vitamineLbx.Items.Clear();
            foreach (var x in FruitTab.TotalVitamine(connectionString, po_selectedFruitLbx.Items))
            {
                po_vitamineLbx.Items.Add(x);
            }
        }

        private void selectedFruitLbx_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            portie = PortieTab.RemoveFromList(Convert.ToString(po_selectedFruitLbx.GetItemText(po_selectedFruitLbx.SelectedItem)));
            po_selectedFruitLbx.Items.Clear();
            po_selectedFruitLbx.Items.AddRange(portie.ToArray());
            try
            {
                po_selectedFruitLbx.SetSelected(po_selectedFruitLbx.Items.Count - 1, true);
            }
            catch (System.ArgumentOutOfRangeException) { }
            po_vitamineLbx.Items.Clear();
            foreach (var x in FruitTab.TotalVitamine(connectionString, po_selectedFruitLbx.Items))
            {
                po_vitamineLbx.Items.Add(x);
            }
        }

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
            snijschijfInputLbl.Text = fruitmachine.switchCuttingDisk(serial).ToString();
        }

        private void BevestigingPanel_VisibleChanged(object sender, EventArgs e)
        {
            snijschijfInputLbl.Text = fruitmachine.switchCuttingDisk(serial).ToString();
        }


        // Persoon Tab
        private void pe_namesLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            pe_leeftijdInputLbl.Text = Convert.ToString(Persoon.GiveAge(connectionString, pe_namesLbx.GetItemText(pe_namesLbx.SelectedItem)));
            pe_naamInputLbl.Text = pe_namesLbx.GetItemText(pe_namesLbx.SelectedItem);
        }

        // Fruit Tab

        private void f_fruitList_lbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                f_vitaminesSelectedFruit_lbx.Items.Clear();
                foreach (string x in Vitamines.GetVitamins(connectionString, f_fruitList_lbx.SelectedItem.ToString()))
                {
                    f_vitaminesSelectedFruit_lbx.Items.Add(x);
                }
                f_vitaminesSelectedFruit_lbx.SetSelected(0, true);
            }
            f_fruitInfo_rtb.Text = Fruit.GiveDescription(connectionString, f_fruitList_lbx.SelectedItem.ToString());
        }

        private void f_vitaminesSelectedFruit_lbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            f_vitamineInfo_rtb.Text = Vitamines.GetVitamineDesc(connectionString, f_vitaminesSelectedFruit_lbx.SelectedItem.ToString());
        }

        // Seriele communicatie

        void FormFruitSnijden_FormClosed(object sender, FormClosedEventArgs e)
        {
            serial.Disconnect();
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
                            string persoonnaam = Persoon.GiveName(connectionString, id);
                            po_persoonLbl.Text = persoonnaam;
                            serial.SendMessage("FINGERPRINT:" + persoonnaam);
                        }
                    }
                    // Else if message =... etc. 
                }
            }
        }

        private void persBtn_Click(object sender, EventArgs e)
        {
            fruitmachine.FruitCut(serial);
        }
    }
}
