﻿namespace FruitMachineDing
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
            this.pe_namesLbx = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pe_leeftijdInputLbl = new System.Windows.Forms.Label();
            this.pe_naamInputLbl = new System.Windows.Forms.Label();
            this.leeftijdLbl = new System.Windows.Forms.Label();
            this.naamLbl = new System.Windows.Forms.Label();
            this.tab_fruitInfo = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.f_fruitInfo_rtb = new System.Windows.Forms.RichTextBox();
            this.f_vitamineInfo_rtb = new System.Windows.Forms.RichTextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.f_vitaminesSelectedFruit_lbx = new System.Windows.Forms.ListBox();
            this.f_fruitList_lbx = new System.Windows.Forms.ListBox();
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
            this.FruitSelectTab.Margin = new System.Windows.Forms.Padding(2);
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
            this.tab_porties.Margin = new System.Windows.Forms.Padding(2);
            this.tab_porties.Name = "tab_porties";
            this.tab_porties.Padding = new System.Windows.Forms.Padding(2);
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
            this.BevestigingPanel.Location = new System.Drawing.Point(526, 215);
            this.BevestigingPanel.Margin = new System.Windows.Forms.Padding(2);
            this.BevestigingPanel.Name = "BevestigingPanel";
            this.BevestigingPanel.Size = new System.Drawing.Size(670, 356);
            this.BevestigingPanel.TabIndex = 1;
            this.BevestigingPanel.Visible = false;
            this.BevestigingPanel.VisibleChanged += new System.EventHandler(this.BevestigingPanel_VisibleChanged);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(14, 86);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(108, 24);
            this.backBtn.TabIndex = 8;
            this.backBtn.Text = "Ga terug";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // persBtn
            // 
            this.persBtn.Location = new System.Drawing.Point(14, 61);
            this.persBtn.Margin = new System.Windows.Forms.Padding(2);
            this.persBtn.Name = "persBtn";
            this.persBtn.Size = new System.Drawing.Size(108, 20);
            this.persBtn.TabIndex = 7;
            this.persBtn.Text = "Pers";
            this.persBtn.UseVisualStyleBackColor = true;
            this.persBtn.Click += new System.EventHandler(this.persBtn_Click);
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
            this.snijschijfLbl.Size = new System.Drawing.Size(88, 13);
            this.snijschijfLbl.TabIndex = 5;
            this.snijschijfLbl.Text = "Huidige snijschijf:";
            // 
            // snijschijfBtn
            // 
            this.snijschijfBtn.Location = new System.Drawing.Point(14, 36);
            this.snijschijfBtn.Margin = new System.Windows.Forms.Padding(2);
            this.snijschijfBtn.Name = "snijschijfBtn";
            this.snijschijfBtn.Size = new System.Drawing.Size(108, 20);
            this.snijschijfBtn.TabIndex = 4;
            this.snijschijfBtn.Text = "Verander snijschijf";
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
            this.BevestigKnop.Margin = new System.Windows.Forms.Padding(2);
            this.BevestigKnop.Name = "BevestigKnop";
            this.BevestigKnop.Size = new System.Drawing.Size(98, 21);
            this.BevestigKnop.TabIndex = 6;
            this.BevestigKnop.Text = "Bevestig";
            this.BevestigKnop.UseVisualStyleBackColor = true;
            this.BevestigKnop.Click += new System.EventHandler(this.BevestigKnop_Click);
            // 
            // po_vitamineLbx
            // 
            this.po_vitamineLbx.FormattingEnabled = true;
            this.po_vitamineLbx.Location = new System.Drawing.Point(436, 48);
            this.po_vitamineLbx.Margin = new System.Windows.Forms.Padding(2);
            this.po_vitamineLbx.Name = "po_vitamineLbx";
            this.po_vitamineLbx.Size = new System.Drawing.Size(188, 264);
            this.po_vitamineLbx.TabIndex = 3;
            // 
            // po_selectedFruitLbx
            // 
            this.po_selectedFruitLbx.FormattingEnabled = true;
            this.po_selectedFruitLbx.Location = new System.Drawing.Point(222, 48);
            this.po_selectedFruitLbx.Margin = new System.Windows.Forms.Padding(2);
            this.po_selectedFruitLbx.Name = "po_selectedFruitLbx";
            this.po_selectedFruitLbx.Size = new System.Drawing.Size(188, 290);
            this.po_selectedFruitLbx.TabIndex = 2;
            this.po_selectedFruitLbx.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.selectedFruitLbx_MouseDoubleClick);
            // 
            // po_fruitLbx
            // 
            this.po_fruitLbx.FormattingEnabled = true;
            this.po_fruitLbx.Location = new System.Drawing.Point(7, 48);
            this.po_fruitLbx.Margin = new System.Windows.Forms.Padding(2);
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
            this.tab_personen.Controls.Add(this.pe_namesLbx);
            this.tab_personen.Controls.Add(this.label4);
            this.tab_personen.Controls.Add(this.pe_leeftijdInputLbl);
            this.tab_personen.Controls.Add(this.pe_naamInputLbl);
            this.tab_personen.Controls.Add(this.leeftijdLbl);
            this.tab_personen.Controls.Add(this.naamLbl);
            this.tab_personen.Location = new System.Drawing.Point(4, 22);
            this.tab_personen.Margin = new System.Windows.Forms.Padding(2);
            this.tab_personen.Name = "tab_personen";
            this.tab_personen.Padding = new System.Windows.Forms.Padding(2);
            this.tab_personen.Size = new System.Drawing.Size(668, 353);
            this.tab_personen.TabIndex = 1;
            this.tab_personen.Text = "Personen";
            this.tab_personen.UseVisualStyleBackColor = true;
            // 
            // pe_namesLbx
            // 
            this.pe_namesLbx.FormattingEnabled = true;
            this.pe_namesLbx.Location = new System.Drawing.Point(7, 48);
            this.pe_namesLbx.Margin = new System.Windows.Forms.Padding(2);
            this.pe_namesLbx.Name = "pe_namesLbx";
            this.pe_namesLbx.Size = new System.Drawing.Size(188, 290);
            this.pe_namesLbx.TabIndex = 13;
            this.pe_namesLbx.SelectedIndexChanged += new System.EventHandler(this.pe_namesLbx_SelectedIndexChanged);
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
            this.tab_fruitInfo.Controls.Add(this.label2);
            this.tab_fruitInfo.Controls.Add(this.f_fruitInfo_rtb);
            this.tab_fruitInfo.Controls.Add(this.f_vitamineInfo_rtb);
            this.tab_fruitInfo.Controls.Add(this.Label1);
            this.tab_fruitInfo.Controls.Add(this.f_vitaminesSelectedFruit_lbx);
            this.tab_fruitInfo.Controls.Add(this.f_fruitList_lbx);
            this.tab_fruitInfo.Location = new System.Drawing.Point(4, 22);
            this.tab_fruitInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tab_fruitInfo.Name = "tab_fruitInfo";
            this.tab_fruitInfo.Padding = new System.Windows.Forms.Padding(2);
            this.tab_fruitInfo.Size = new System.Drawing.Size(668, 353);
            this.tab_fruitInfo.TabIndex = 2;
            this.tab_fruitInfo.Text = "Fruit info";
            this.tab_fruitInfo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Extra informatie over de vitamine:";
            // 
            // f_fruitInfo_rtb
            // 
            this.f_fruitInfo_rtb.Location = new System.Drawing.Point(391, 31);
            this.f_fruitInfo_rtb.Name = "f_fruitInfo_rtb";
            this.f_fruitInfo_rtb.ReadOnly = true;
            this.f_fruitInfo_rtb.Size = new System.Drawing.Size(269, 143);
            this.f_fruitInfo_rtb.TabIndex = 7;
            this.f_fruitInfo_rtb.Text = "";
            // 
            // f_vitamineInfo_rtb
            // 
            this.f_vitamineInfo_rtb.Location = new System.Drawing.Point(391, 201);
            this.f_vitamineInfo_rtb.Name = "f_vitamineInfo_rtb";
            this.f_vitamineInfo_rtb.ReadOnly = true;
            this.f_vitamineInfo_rtb.Size = new System.Drawing.Size(269, 143);
            this.f_vitamineInfo_rtb.TabIndex = 8;
            this.f_vitamineInfo_rtb.Text = "";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(388, 15);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(144, 13);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Extra informatie over het fruit:";
            // 
            // f_vitaminesSelectedFruit_lbx
            // 
            this.f_vitaminesSelectedFruit_lbx.FormattingEnabled = true;
            this.f_vitaminesSelectedFruit_lbx.Location = new System.Drawing.Point(198, 31);
            this.f_vitaminesSelectedFruit_lbx.Margin = new System.Windows.Forms.Padding(2);
            this.f_vitaminesSelectedFruit_lbx.Name = "f_vitaminesSelectedFruit_lbx";
            this.f_vitaminesSelectedFruit_lbx.Size = new System.Drawing.Size(188, 316);
            this.f_vitaminesSelectedFruit_lbx.TabIndex = 3;
            this.f_vitaminesSelectedFruit_lbx.SelectedIndexChanged += new System.EventHandler(this.f_vitaminesSelectedFruit_lbx_SelectedIndexChanged);
            // 
            // f_fruitList_lbx
            // 
            this.f_fruitList_lbx.FormattingEnabled = true;
            this.f_fruitList_lbx.Location = new System.Drawing.Point(6, 31);
            this.f_fruitList_lbx.Margin = new System.Windows.Forms.Padding(2);
            this.f_fruitList_lbx.Name = "f_fruitList_lbx";
            this.f_fruitList_lbx.Size = new System.Drawing.Size(188, 316);
            this.f_fruitList_lbx.TabIndex = 2;
            this.f_fruitList_lbx.SelectedIndexChanged += new System.EventHandler(this.f_fruitList_lbx_SelectedIndexChanged);
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
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 378);
            this.Controls.Add(this.FruitSelectTab);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(692, 417);
            this.MinimumSize = new System.Drawing.Size(692, 417);
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
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ListBox f_vitaminesSelectedFruit_lbx;
        private System.Windows.Forms.ListBox f_fruitList_lbx;
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
        private System.Windows.Forms.ListBox pe_namesLbx;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.RichTextBox f_fruitInfo_rtb;
        private System.Windows.Forms.RichTextBox f_vitamineInfo_rtb;
        private System.Windows.Forms.Label label2;
    }
}

