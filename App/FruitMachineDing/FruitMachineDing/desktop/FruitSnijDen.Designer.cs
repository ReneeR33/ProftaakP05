namespace FruitMachineDing
{
    partial class FruitSnijden
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FruitSelectTab = new System.Windows.Forms.TabControl();
            this.tab_porties = new System.Windows.Forms.TabPage();
            this.BevestigingPanel = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.persBtn = new System.Windows.Forms.Button();
            this.snijschijfInputLbl = new System.Windows.Forms.Label();
            this.snijschijfLbl = new System.Windows.Forms.Label();
            this.snijschijfBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.selectedFruitLbl = new System.Windows.Forms.Label();
            this.fruitLbl = new System.Windows.Forms.Label();
            this.BevestigKnop = new System.Windows.Forms.Button();
            this.po_vitamineLbx = new System.Windows.Forms.ListBox();
            this.po_selectedFruitLbx = new System.Windows.Forms.ListBox();
            this.po_fruitLbx = new System.Windows.Forms.ListBox();
            this.po_persoonLbl = new System.Windows.Forms.Label();
            this.tab_personen = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pe_button = new System.Windows.Forms.Button();
            this.pe_leeftijdInputLbl = new System.Windows.Forms.Label();
            this.pe_naamInputLbl = new System.Windows.Forms.Label();
            this.leeftijdLbl = new System.Windows.Forms.Label();
            this.naamLbl = new System.Windows.Forms.Label();
            this.tab_fruitInfo = new System.Windows.Forms.TabPage();
            this.fruitInfoLbl = new System.Windows.Forms.Label();
            this.f_SelectedFruitLbx = new System.Windows.Forms.ListBox();
            this.f_fruitInfoLbx = new System.Windows.Forms.ListBox();
            this.PersoonLbx = new System.Windows.Forms.ListBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.FruitSelectTab.SuspendLayout();
            this.tab_porties.SuspendLayout();
            this.BevestigingPanel.SuspendLayout();
            this.tab_personen.SuspendLayout();
            this.tab_fruitInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // FruitSelectTab
            // 
            this.FruitSelectTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FruitSelectTab.Controls.Add(this.tab_porties);
            this.FruitSelectTab.Controls.Add(this.tab_personen);
            this.FruitSelectTab.Controls.Add(this.tab_fruitInfo);
            this.FruitSelectTab.Location = new System.Drawing.Point(0, 0);
            this.FruitSelectTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FruitSelectTab.Name = "FruitSelectTab";
            this.FruitSelectTab.SelectedIndex = 0;
            this.FruitSelectTab.Size = new System.Drawing.Size(676, 379);
            this.FruitSelectTab.TabIndex = 0;
            // 
            // tab_porties
            // 
            this.tab_porties.Controls.Add(this.BevestigingPanel);
            this.tab_porties.Controls.Add(this.label3);
            this.tab_porties.Controls.Add(this.selectedFruitLbl);
            this.tab_porties.Controls.Add(this.fruitLbl);
            this.tab_porties.Controls.Add(this.BevestigKnop);
            this.tab_porties.Controls.Add(this.po_vitamineLbx);
            this.tab_porties.Controls.Add(this.po_selectedFruitLbx);
            this.tab_porties.Controls.Add(this.po_fruitLbx);
            this.tab_porties.Controls.Add(this.po_persoonLbl);
            this.tab_porties.Location = new System.Drawing.Point(4, 22);
            this.tab_porties.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_porties.Name = "tab_porties";
            this.tab_porties.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_porties.Size = new System.Drawing.Size(668, 353);
            this.tab_porties.TabIndex = 0;
            this.tab_porties.Text = "Porties";
            this.tab_porties.UseVisualStyleBackColor = true;
            // 
            // BevestigingPanel
            // 
            this.BevestigingPanel.Controls.Add(this.backBtn);
            this.BevestigingPanel.Controls.Add(this.persBtn);
            this.BevestigingPanel.Controls.Add(this.snijschijfInputLbl);
            this.BevestigingPanel.Controls.Add(this.snijschijfLbl);
            this.BevestigingPanel.Controls.Add(this.snijschijfBtn);
            this.BevestigingPanel.Location = new System.Drawing.Point(526, 33);
            this.BevestigingPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BevestigingPanel.Name = "BevestigingPanel";
            this.BevestigingPanel.Size = new System.Drawing.Size(670, 356);
            this.BevestigingPanel.TabIndex = 1;
            this.BevestigingPanel.Visible = false;
            this.BevestigingPanel.VisibleChanged += new System.EventHandler(this.BevestigingPanel_VisibleChanged);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(14, 86);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(108, 24);
            this.backBtn.TabIndex = 8;
            this.backBtn.Text = "ga terug";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // persBtn
            // 
            this.persBtn.Location = new System.Drawing.Point(14, 61);
            this.persBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.persBtn.Name = "persBtn";
            this.persBtn.Size = new System.Drawing.Size(108, 20);
            this.persBtn.TabIndex = 7;
            this.persBtn.Text = "pers";
            this.persBtn.UseVisualStyleBackColor = true;
            // 
            // snijschijfInputLbl
            // 
            this.snijschijfInputLbl.AutoSize = true;
            this.snijschijfInputLbl.Location = new System.Drawing.Point(102, 20);
            this.snijschijfInputLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.snijschijfInputLbl.Name = "snijschijfInputLbl";
            this.snijschijfInputLbl.Size = new System.Drawing.Size(83, 13);
            this.snijschijfInputLbl.TabIndex = 6;
            this.snijschijfInputLbl.Text = "huidige snijschijf";
            // 
            // snijschijfLbl
            // 
            this.snijschijfLbl.AutoSize = true;
            this.snijschijfLbl.Location = new System.Drawing.Point(11, 20);
            this.snijschijfLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.snijschijfLbl.Name = "snijschijfLbl";
            this.snijschijfLbl.Size = new System.Drawing.Size(86, 13);
            this.snijschijfLbl.TabIndex = 5;
            this.snijschijfLbl.Text = "huidige snijschijf:";
            // 
            // snijschijfBtn
            // 
            this.snijschijfBtn.Location = new System.Drawing.Point(14, 36);
            this.snijschijfBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.snijschijfBtn.Name = "snijschijfBtn";
            this.snijschijfBtn.Size = new System.Drawing.Size(108, 20);
            this.snijschijfBtn.TabIndex = 4;
            this.snijschijfBtn.Text = "verander snijschijf";
            this.snijschijfBtn.UseVisualStyleBackColor = true;
            this.snijschijfBtn.Click += new System.EventHandler(this.snijschijfBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Vitamines:";
            // 
            // selectedFruitLbl
            // 
            this.selectedFruitLbl.AutoSize = true;
            this.selectedFruitLbl.Location = new System.Drawing.Point(219, 33);
            this.selectedFruitLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectedFruitLbl.Name = "selectedFruitLbl";
            this.selectedFruitLbl.Size = new System.Drawing.Size(93, 13);
            this.selectedFruitLbl.TabIndex = 8;
            this.selectedFruitLbl.Text = "Geselecteerd fruit:";
            // 
            // fruitLbl
            // 
            this.fruitLbl.AutoSize = true;
            this.fruitLbl.Location = new System.Drawing.Point(4, 33);
            this.fruitLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fruitLbl.Name = "fruitLbl";
            this.fruitLbl.Size = new System.Drawing.Size(30, 13);
            this.fruitLbl.TabIndex = 7;
            this.fruitLbl.Text = "Fruit:";
            // 
            // BevestigKnop
            // 
            this.BevestigKnop.Location = new System.Drawing.Point(526, 325);
            this.BevestigKnop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BevestigKnop.Name = "BevestigKnop";
            this.BevestigKnop.Size = new System.Drawing.Size(98, 21);
            this.BevestigKnop.TabIndex = 6;
            this.BevestigKnop.Text = "bevestig";
            this.BevestigKnop.UseVisualStyleBackColor = true;
            this.BevestigKnop.Click += new System.EventHandler(this.BevestigKnop_Click);
            // 
            // po_vitamineLbx
            // 
            this.po_vitamineLbx.FormattingEnabled = true;
            this.po_vitamineLbx.Location = new System.Drawing.Point(436, 48);
            this.po_vitamineLbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.po_vitamineLbx.Name = "po_vitamineLbx";
            this.po_vitamineLbx.Size = new System.Drawing.Size(188, 264);
            this.po_vitamineLbx.TabIndex = 3;
            // 
            // po_selectedFruitLbx
            // 
            this.po_selectedFruitLbx.FormattingEnabled = true;
            this.po_selectedFruitLbx.Location = new System.Drawing.Point(222, 48);
            this.po_selectedFruitLbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.po_selectedFruitLbx.Name = "po_selectedFruitLbx";
            this.po_selectedFruitLbx.Size = new System.Drawing.Size(188, 290);
            this.po_selectedFruitLbx.TabIndex = 2;
            this.po_selectedFruitLbx.SelectedIndexChanged += new System.EventHandler(this.selectedFruitLbx_SelectedIndexChanged);
            this.po_selectedFruitLbx.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.selectedFruitLbx_MouseDoubleClick);
            // 
            // po_fruitLbx
            // 
            this.po_fruitLbx.FormattingEnabled = true;
            this.po_fruitLbx.Location = new System.Drawing.Point(7, 48);
            this.po_fruitLbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.po_fruitLbx.Name = "po_fruitLbx";
            this.po_fruitLbx.Size = new System.Drawing.Size(188, 290);
            this.po_fruitLbx.TabIndex = 1;
            this.po_fruitLbx.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FruitLbx_MouseDoubleClick);
            // 
            // po_persoonLbl
            // 
            this.po_persoonLbl.AutoSize = true;
            this.po_persoonLbl.Location = new System.Drawing.Point(6, 2);
            this.po_persoonLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.po_persoonLbl.Name = "po_persoonLbl";
            this.po_persoonLbl.Size = new System.Drawing.Size(114, 13);
            this.po_persoonLbl.TabIndex = 0;
            this.po_persoonLbl.Text = "lbl_persoonNaamHiero";
            // 
            // tab_personen
            // 
            this.tab_personen.Controls.Add(this.listBox1);
            this.tab_personen.Controls.Add(this.label4);
            this.tab_personen.Controls.Add(this.pe_button);
            this.tab_personen.Controls.Add(this.pe_leeftijdInputLbl);
            this.tab_personen.Controls.Add(this.pe_naamInputLbl);
            this.tab_personen.Controls.Add(this.leeftijdLbl);
            this.tab_personen.Controls.Add(this.naamLbl);
            this.tab_personen.Location = new System.Drawing.Point(4, 22);
            this.tab_personen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_personen.Name = "tab_personen";
            this.tab_personen.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_personen.Size = new System.Drawing.Size(668, 353);
            this.tab_personen.TabIndex = 1;
            this.tab_personen.Text = "Personen";
            this.tab_personen.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 48);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 290);
            this.listBox1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Personen:";
            // 
            // pe_button
            // 
            this.pe_button.Location = new System.Drawing.Point(226, 312);
            this.pe_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pe_button.Name = "pe_button";
            this.pe_button.Size = new System.Drawing.Size(76, 26);
            this.pe_button.TabIndex = 11;
            this.pe_button.Text = "log in";
            this.pe_button.UseVisualStyleBackColor = true;
            // 
            // pe_leeftijdInputLbl
            // 
            this.pe_leeftijdInputLbl.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.pe_leeftijdInputLbl.AutoSize = true;
            this.pe_leeftijdInputLbl.Location = new System.Drawing.Point(294, 79);
            this.pe_leeftijdInputLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pe_leeftijdInputLbl.Name = "pe_leeftijdInputLbl";
            this.pe_leeftijdInputLbl.Size = new System.Drawing.Size(39, 13);
            this.pe_leeftijdInputLbl.TabIndex = 8;
            this.pe_leeftijdInputLbl.Text = "Label2";
            // 
            // pe_naamInputLbl
            // 
            this.pe_naamInputLbl.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.pe_naamInputLbl.AutoSize = true;
            this.pe_naamInputLbl.Location = new System.Drawing.Point(294, 57);
            this.pe_naamInputLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pe_naamInputLbl.Name = "pe_naamInputLbl";
            this.pe_naamInputLbl.Size = new System.Drawing.Size(39, 13);
            this.pe_naamInputLbl.TabIndex = 6;
            this.pe_naamInputLbl.Text = "Label1";
            // 
            // leeftijdLbl
            // 
            this.leeftijdLbl.AutoSize = true;
            this.leeftijdLbl.Location = new System.Drawing.Point(223, 79);
            this.leeftijdLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.leeftijdLbl.Name = "leeftijdLbl";
            this.leeftijdLbl.Size = new System.Drawing.Size(44, 13);
            this.leeftijdLbl.TabIndex = 3;
            this.leeftijdLbl.Text = "Leeftijd:";
            // 
            // naamLbl
            // 
            this.naamLbl.AutoSize = true;
            this.naamLbl.Location = new System.Drawing.Point(223, 57);
            this.naamLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.naamLbl.Name = "naamLbl";
            this.naamLbl.Size = new System.Drawing.Size(38, 13);
            this.naamLbl.TabIndex = 1;
            this.naamLbl.Text = "Naam:";
            // 
            // tab_fruitInfo
            // 
            this.tab_fruitInfo.Controls.Add(this.fruitInfoLbl);
            this.tab_fruitInfo.Controls.Add(this.f_SelectedFruitLbx);
            this.tab_fruitInfo.Controls.Add(this.f_fruitInfoLbx);
            this.tab_fruitInfo.Location = new System.Drawing.Point(4, 22);
            this.tab_fruitInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_fruitInfo.Name = "tab_fruitInfo";
            this.tab_fruitInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_fruitInfo.Size = new System.Drawing.Size(668, 353);
            this.tab_fruitInfo.TabIndex = 2;
            this.tab_fruitInfo.Text = "Fruit info";
            this.tab_fruitInfo.UseVisualStyleBackColor = true;
            // 
            // fruitInfoLbl
            // 
            this.fruitInfoLbl.AutoSize = true;
            this.fruitInfoLbl.Location = new System.Drawing.Point(419, 31);
            this.fruitInfoLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fruitInfoLbl.Name = "fruitInfoLbl";
            this.fruitInfoLbl.Size = new System.Drawing.Size(24, 13);
            this.fruitInfoLbl.TabIndex = 6;
            this.fruitInfoLbl.Text = "test";
            // 
            // f_SelectedFruitLbx
            // 
            this.f_SelectedFruitLbx.FormattingEnabled = true;
            this.f_SelectedFruitLbx.Location = new System.Drawing.Point(198, 31);
            this.f_SelectedFruitLbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f_SelectedFruitLbx.Name = "f_SelectedFruitLbx";
            this.f_SelectedFruitLbx.Size = new System.Drawing.Size(188, 316);
            this.f_SelectedFruitLbx.TabIndex = 3;
            this.f_SelectedFruitLbx.SelectedIndexChanged += new System.EventHandler(this.SelectedFruitLbx2_SelectedIndexChanged);
            // 
            // f_fruitInfoLbx
            // 
            this.f_fruitInfoLbx.FormattingEnabled = true;
            this.f_fruitInfoLbx.Location = new System.Drawing.Point(6, 31);
            this.f_fruitInfoLbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f_fruitInfoLbx.Name = "f_fruitInfoLbx";
            this.f_fruitInfoLbx.Size = new System.Drawing.Size(188, 316);
            this.f_fruitInfoLbx.TabIndex = 2;
            this.f_fruitInfoLbx.SelectedIndexChanged += new System.EventHandler(this.fruitInfoLbx_SelectedIndexChanged);
            // 
            // PersoonLbx
            // 
            this.PersoonLbx.Location = new System.Drawing.Point(0, 0);
            this.PersoonLbx.Name = "PersoonLbx";
            this.PersoonLbx.Size = new System.Drawing.Size(120, 96);
            this.PersoonLbx.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FruitSnijden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 380);
            this.Controls.Add(this.FruitSelectTab);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(692, 419);
            this.MinimumSize = new System.Drawing.Size(692, 419);
            this.Name = "FruitSnijden";
            this.Text = "Fruit snijden";
            this.Load += new System.EventHandler(this.FruitSnijden_Load);
            this.FruitSelectTab.ResumeLayout(false);
            this.tab_porties.ResumeLayout(false);
            this.tab_porties.PerformLayout();
            this.BevestigingPanel.ResumeLayout(false);
            this.BevestigingPanel.PerformLayout();
            this.tab_personen.ResumeLayout(false);
            this.tab_personen.PerformLayout();
            this.tab_fruitInfo.ResumeLayout(false);
            this.tab_fruitInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl FruitSelectTab;
        private System.Windows.Forms.TabPage tab_porties;
        private System.Windows.Forms.TabPage tab_personen;
        private System.Windows.Forms.ListBox po_vitamineLbx;
        private System.Windows.Forms.ListBox po_selectedFruitLbx;
        private System.Windows.Forms.ListBox po_fruitLbx;
        private System.Windows.Forms.Label po_persoonLbl;
        private System.Windows.Forms.TabPage tab_fruitInfo;
        private System.Windows.Forms.Button BevestigKnop;
        private System.Windows.Forms.Label pe_leeftijdInputLbl;
        private System.Windows.Forms.Label pe_naamInputLbl;
        private System.Windows.Forms.Label leeftijdLbl;
        private System.Windows.Forms.Label naamLbl;
        private System.Windows.Forms.ListBox PersoonLbx;
        private System.Windows.Forms.Button pe_button;
        private System.Windows.Forms.Label fruitInfoLbl;
        private System.Windows.Forms.ListBox f_SelectedFruitLbx;
        private System.Windows.Forms.ListBox f_fruitInfoLbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label selectedFruitLbl;
        private System.Windows.Forms.Label fruitLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel BevestigingPanel;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button persBtn;
        private System.Windows.Forms.Label snijschijfInputLbl;
        private System.Windows.Forms.Label snijschijfLbl;
        private System.Windows.Forms.Button snijschijfBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer;
    }
}

