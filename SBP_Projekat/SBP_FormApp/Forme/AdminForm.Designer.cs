﻿namespace SBP_Projekat.Forme
{
    partial class AdminForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.igraciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predmetiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sesijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_predmeti = new System.Windows.Forms.DataGridView();
            this.xpBonusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaOruzjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predmetDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_sesije = new System.Windows.Forms.DataGridView();
            this.sesijaDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaradjeniXPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vremePocetkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vremeKrajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igracNazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.likRasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_predmeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sesije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sesijaDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.igraciToolStripMenuItem,
            this.raseToolStripMenuItem,
            this.predmetiToolStripMenuItem,
            this.questoviToolStripMenuItem,
            this.sesijeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // igraciToolStripMenuItem
            // 
            this.igraciToolStripMenuItem.Name = "igraciToolStripMenuItem";
            this.igraciToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.igraciToolStripMenuItem.Text = "Igraci";
            // 
            // raseToolStripMenuItem
            // 
            this.raseToolStripMenuItem.Name = "raseToolStripMenuItem";
            this.raseToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.raseToolStripMenuItem.Text = "Rase";
            this.raseToolStripMenuItem.Click += new System.EventHandler(this.raseToolStripMenuItem_Click);
            // 
            // predmetiToolStripMenuItem
            // 
            this.predmetiToolStripMenuItem.Name = "predmetiToolStripMenuItem";
            this.predmetiToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.predmetiToolStripMenuItem.Text = "Predmeti";
            this.predmetiToolStripMenuItem.Click += new System.EventHandler(this.predmetiToolStripMenuItem_Click);
            // 
            // questoviToolStripMenuItem
            // 
            this.questoviToolStripMenuItem.Name = "questoviToolStripMenuItem";
            this.questoviToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.questoviToolStripMenuItem.Text = "Questovi";
            // 
            // sesijeToolStripMenuItem
            // 
            this.sesijeToolStripMenuItem.Name = "sesijeToolStripMenuItem";
            this.sesijeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.sesijeToolStripMenuItem.Text = "Sesije";
            this.sesijeToolStripMenuItem.Click += new System.EventHandler(this.sesijeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trenutno aktivnih igraca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "0";
            // 
            // dgv_predmeti
            // 
            this.dgv_predmeti.AllowUserToAddRows = false;
            this.dgv_predmeti.AllowUserToDeleteRows = false;
            this.dgv_predmeti.AutoGenerateColumns = false;
            this.dgv_predmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_predmeti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xpBonusDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.vrstaOruzjaDataGridViewTextBoxColumn});
            this.dgv_predmeti.DataSource = this.predmetDTOBindingSource;
            this.dgv_predmeti.Location = new System.Drawing.Point(15, 69);
            this.dgv_predmeti.Name = "dgv_predmeti";
            this.dgv_predmeti.ReadOnly = true;
            this.dgv_predmeti.Size = new System.Drawing.Size(758, 346);
            this.dgv_predmeti.TabIndex = 3;
            // 
            // xpBonusDataGridViewTextBoxColumn
            // 
            this.xpBonusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.xpBonusDataGridViewTextBoxColumn.DataPropertyName = "XpBonus";
            this.xpBonusDataGridViewTextBoxColumn.HeaderText = "XpBonus";
            this.xpBonusDataGridViewTextBoxColumn.Name = "xpBonusDataGridViewTextBoxColumn";
            this.xpBonusDataGridViewTextBoxColumn.ReadOnly = true;
            this.xpBonusDataGridViewTextBoxColumn.Width = 75;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazivDataGridViewTextBoxColumn.Width = 59;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrstaOruzjaDataGridViewTextBoxColumn
            // 
            this.vrstaOruzjaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.vrstaOruzjaDataGridViewTextBoxColumn.DataPropertyName = "VrstaOruzja";
            this.vrstaOruzjaDataGridViewTextBoxColumn.HeaderText = "VrstaOruzja";
            this.vrstaOruzjaDataGridViewTextBoxColumn.Name = "vrstaOruzjaDataGridViewTextBoxColumn";
            this.vrstaOruzjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.vrstaOruzjaDataGridViewTextBoxColumn.Width = 86;
            // 
            // predmetDTOBindingSource
            // 
            this.predmetDTOBindingSource.DataSource = typeof(SBP_Data.DTOs.PredmetDTO);
            // 
            // dgv_sesije
            // 
            this.dgv_sesije.AllowUserToAddRows = false;
            this.dgv_sesije.AllowUserToDeleteRows = false;
            this.dgv_sesije.AutoGenerateColumns = false;
            this.dgv_sesije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sesije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goldDataGridViewTextBoxColumn,
            this.zaradjeniXPDataGridViewTextBoxColumn,
            this.vremePocetkaDataGridViewTextBoxColumn,
            this.vremeKrajaDataGridViewTextBoxColumn,
            this.igracNazivDataGridViewTextBoxColumn,
            this.likRasaDataGridViewTextBoxColumn});
            this.dgv_sesije.DataSource = this.sesijaDTOBindingSource;
            this.dgv_sesije.Location = new System.Drawing.Point(15, 69);
            this.dgv_sesije.Name = "dgv_sesije";
            this.dgv_sesije.ReadOnly = true;
            this.dgv_sesije.Size = new System.Drawing.Size(758, 346);
            this.dgv_sesije.TabIndex = 4;
            // 
            // sesijaDTOBindingSource
            // 
            this.sesijaDTOBindingSource.DataSource = typeof(SBP_Data.DTOs.SesijaDTO);
            // 
            // goldDataGridViewTextBoxColumn
            // 
            this.goldDataGridViewTextBoxColumn.DataPropertyName = "Gold";
            this.goldDataGridViewTextBoxColumn.HeaderText = "Gold";
            this.goldDataGridViewTextBoxColumn.Name = "goldDataGridViewTextBoxColumn";
            this.goldDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zaradjeniXPDataGridViewTextBoxColumn
            // 
            this.zaradjeniXPDataGridViewTextBoxColumn.DataPropertyName = "ZaradjeniXP";
            this.zaradjeniXPDataGridViewTextBoxColumn.HeaderText = "ZaradjeniXP";
            this.zaradjeniXPDataGridViewTextBoxColumn.Name = "zaradjeniXPDataGridViewTextBoxColumn";
            this.zaradjeniXPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vremePocetkaDataGridViewTextBoxColumn
            // 
            this.vremePocetkaDataGridViewTextBoxColumn.DataPropertyName = "VremePocetka";
            this.vremePocetkaDataGridViewTextBoxColumn.HeaderText = "VremePocetka";
            this.vremePocetkaDataGridViewTextBoxColumn.Name = "vremePocetkaDataGridViewTextBoxColumn";
            this.vremePocetkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vremeKrajaDataGridViewTextBoxColumn
            // 
            this.vremeKrajaDataGridViewTextBoxColumn.DataPropertyName = "VremeKraja";
            this.vremeKrajaDataGridViewTextBoxColumn.HeaderText = "VremeKraja";
            this.vremeKrajaDataGridViewTextBoxColumn.Name = "vremeKrajaDataGridViewTextBoxColumn";
            this.vremeKrajaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // igracNazivDataGridViewTextBoxColumn
            // 
            this.igracNazivDataGridViewTextBoxColumn.DataPropertyName = "IgracNaziv";
            this.igracNazivDataGridViewTextBoxColumn.HeaderText = "IgracNaziv";
            this.igracNazivDataGridViewTextBoxColumn.Name = "igracNazivDataGridViewTextBoxColumn";
            this.igracNazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // likRasaDataGridViewTextBoxColumn
            // 
            this.likRasaDataGridViewTextBoxColumn.DataPropertyName = "LikRasa";
            this.likRasaDataGridViewTextBoxColumn.HeaderText = "LikRasa";
            this.likRasaDataGridViewTextBoxColumn.Name = "likRasaDataGridViewTextBoxColumn";
            this.likRasaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_sesije);
            this.Controls.Add(this.dgv_predmeti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_predmeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sesije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sesijaDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem igraciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predmetiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sesijeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_predmeti;
        private System.Windows.Forms.BindingSource predmetDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpBonusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaOruzjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgv_sesije;
        private System.Windows.Forms.DataGridViewTextBoxColumn goldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaradjeniXPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vremePocetkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vremeKrajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn igracNazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn likRasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sesijaDTOBindingSource;
    }
}