namespace SBP_Projekat.Forme
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
            this.goldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaradjeniXPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vremePocetkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vremeKrajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igracNazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.likRasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sesijaDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgv_igraci = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uzrastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nadimakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igracDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmd_deleteUser = new System.Windows.Forms.Button();
            this.dgv_quest = new System.Windows.Forms.DataGridView();
            this.xpGainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.num_xpgain = new System.Windows.Forms.NumericUpDown();
            this.cmd_dodaj_quest = new System.Windows.Forms.Button();
            this.label_xpgain = new System.Windows.Forms.Label();
            this.cmd_delete_quest = new System.Windows.Forms.Button();
            this.cmd_delete_item = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_predmeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sesije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sesijaDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_igraci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igracDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_xpgain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.igraciToolStripMenuItem,
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
            this.igraciToolStripMenuItem.Click += new System.EventHandler(this.igraciToolStripMenuItem_Click);
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
            this.questoviToolStripMenuItem.Click += new System.EventHandler(this.questoviToolStripMenuItem_Click);
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
            // sesijaDTOBindingSource
            // 
            this.sesijaDTOBindingSource.DataSource = typeof(SBP_Data.DTOs.SesijaDTO);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(179, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(535, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Prethodnih 10";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(626, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Sledecih 10";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGray;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(290, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Dodaj predmet";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgv_igraci
            // 
            this.dgv_igraci.AllowUserToAddRows = false;
            this.dgv_igraci.AllowUserToDeleteRows = false;
            this.dgv_igraci.AutoGenerateColumns = false;
            this.dgv_igraci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_igraci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.uzrastDataGridViewTextBoxColumn,
            this.nadimakDataGridViewTextBoxColumn,
            this.polDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn});
            this.dgv_igraci.DataSource = this.igracDTOBindingSource;
            this.dgv_igraci.Location = new System.Drawing.Point(14, 69);
            this.dgv_igraci.Name = "dgv_igraci";
            this.dgv_igraci.ReadOnly = true;
            this.dgv_igraci.Size = new System.Drawing.Size(758, 346);
            this.dgv_igraci.TabIndex = 9;
            this.dgv_igraci.VisibleChanged += new System.EventHandler(this.dgv_igraci_VisibleChanged);
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uzrastDataGridViewTextBoxColumn
            // 
            this.uzrastDataGridViewTextBoxColumn.DataPropertyName = "Uzrast";
            this.uzrastDataGridViewTextBoxColumn.HeaderText = "Uzrast";
            this.uzrastDataGridViewTextBoxColumn.Name = "uzrastDataGridViewTextBoxColumn";
            this.uzrastDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nadimakDataGridViewTextBoxColumn
            // 
            this.nadimakDataGridViewTextBoxColumn.DataPropertyName = "Nadimak";
            this.nadimakDataGridViewTextBoxColumn.HeaderText = "Nadimak";
            this.nadimakDataGridViewTextBoxColumn.Name = "nadimakDataGridViewTextBoxColumn";
            this.nadimakDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // polDataGridViewTextBoxColumn
            // 
            this.polDataGridViewTextBoxColumn.DataPropertyName = "Pol";
            this.polDataGridViewTextBoxColumn.HeaderText = "Pol";
            this.polDataGridViewTextBoxColumn.Name = "polDataGridViewTextBoxColumn";
            this.polDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // igracDTOBindingSource
            // 
            this.igracDTOBindingSource.DataSource = typeof(SBP_Data.DTOs.IgracDTO);
            // 
            // cmd_deleteUser
            // 
            this.cmd_deleteUser.Location = new System.Drawing.Point(19, 436);
            this.cmd_deleteUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmd_deleteUser.Name = "cmd_deleteUser";
            this.cmd_deleteUser.Size = new System.Drawing.Size(100, 34);
            this.cmd_deleteUser.TabIndex = 10;
            this.cmd_deleteUser.Text = "obrisi korisnika";
            this.cmd_deleteUser.UseVisualStyleBackColor = true;
            this.cmd_deleteUser.Click += new System.EventHandler(this.cmd_deleteUser_Click);
            // 
            // dgv_quest
            // 
            this.dgv_quest.AutoGenerateColumns = false;
            this.dgv_quest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_quest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xpGainDataGridViewTextBoxColumn});
            this.dgv_quest.DataSource = this.questDTOBindingSource;
            this.dgv_quest.Location = new System.Drawing.Point(16, 71);
            this.dgv_quest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_quest.Name = "dgv_quest";
            this.dgv_quest.RowTemplate.Height = 24;
            this.dgv_quest.Size = new System.Drawing.Size(757, 344);
            this.dgv_quest.TabIndex = 11;
            this.dgv_quest.VisibleChanged += new System.EventHandler(this.dgv_quest_VisibleChanged);
            // 
            // xpGainDataGridViewTextBoxColumn
            // 
            this.xpGainDataGridViewTextBoxColumn.DataPropertyName = "XpGain";
            this.xpGainDataGridViewTextBoxColumn.HeaderText = "XpGain";
            this.xpGainDataGridViewTextBoxColumn.Name = "xpGainDataGridViewTextBoxColumn";
            // 
            // questDTOBindingSource
            // 
            this.questDTOBindingSource.DataSource = typeof(SBP_Data.DTOs.QuestDTO);
            // 
            // num_xpgain
            // 
            this.num_xpgain.Location = new System.Drawing.Point(19, 453);
            this.num_xpgain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num_xpgain.Name = "num_xpgain";
            this.num_xpgain.Size = new System.Drawing.Size(84, 20);
            this.num_xpgain.TabIndex = 12;
            // 
            // cmd_dodaj_quest
            // 
            this.cmd_dodaj_quest.BackColor = System.Drawing.Color.LightGray;
            this.cmd_dodaj_quest.FlatAppearance.BorderSize = 0;
            this.cmd_dodaj_quest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_dodaj_quest.Location = new System.Drawing.Point(107, 437);
            this.cmd_dodaj_quest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmd_dodaj_quest.Name = "cmd_dodaj_quest";
            this.cmd_dodaj_quest.Size = new System.Drawing.Size(80, 37);
            this.cmd_dodaj_quest.TabIndex = 13;
            this.cmd_dodaj_quest.Text = "dodaj quest";
            this.cmd_dodaj_quest.UseVisualStyleBackColor = false;
            this.cmd_dodaj_quest.Click += new System.EventHandler(this.cmd_dodaj_quest_Click);
            // 
            // label_xpgain
            // 
            this.label_xpgain.AutoSize = true;
            this.label_xpgain.Location = new System.Drawing.Point(19, 437);
            this.label_xpgain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_xpgain.Name = "label_xpgain";
            this.label_xpgain.Size = new System.Drawing.Size(49, 13);
            this.label_xpgain.TabIndex = 15;
            this.label_xpgain.Text = "xp Gain :";
            // 
            // cmd_delete_quest
            // 
            this.cmd_delete_quest.BackColor = System.Drawing.Color.LightGray;
            this.cmd_delete_quest.FlatAppearance.BorderSize = 0;
            this.cmd_delete_quest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_delete_quest.Location = new System.Drawing.Point(192, 437);
            this.cmd_delete_quest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmd_delete_quest.Name = "cmd_delete_quest";
            this.cmd_delete_quest.Size = new System.Drawing.Size(80, 37);
            this.cmd_delete_quest.TabIndex = 16;
            this.cmd_delete_quest.Text = "obrisi quest";
            this.cmd_delete_quest.UseVisualStyleBackColor = false;
            this.cmd_delete_quest.Click += new System.EventHandler(this.cmd_delete_quest_Click);
            // 
            // cmd_delete_item
            // 
            this.cmd_delete_item.BackColor = System.Drawing.Color.LightGray;
            this.cmd_delete_item.FlatAppearance.BorderSize = 0;
            this.cmd_delete_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_delete_item.Location = new System.Drawing.Point(381, 40);
            this.cmd_delete_item.Name = "cmd_delete_item";
            this.cmd_delete_item.Size = new System.Drawing.Size(85, 23);
            this.cmd_delete_item.TabIndex = 8;
            this.cmd_delete_item.Text = "Izbrisi predmet";
            this.cmd_delete_item.UseVisualStyleBackColor = false;
            this.cmd_delete_item.Visible = false;
            this.cmd_delete_item.Click += new System.EventHandler(this.cmd_delete_item_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.cmd_delete_quest);
            this.Controls.Add(this.label_xpgain);
            this.Controls.Add(this.cmd_dodaj_quest);
            this.Controls.Add(this.num_xpgain);
            this.Controls.Add(this.dgv_quest);
            this.Controls.Add(this.cmd_deleteUser);
            this.Controls.Add(this.dgv_igraci);
            this.Controls.Add(this.cmd_delete_item);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_sesije);
            this.Controls.Add(this.dgv_predmeti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_predmeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sesije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sesijaDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_igraci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igracDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_xpgain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem igraciToolStripMenuItem;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgv_igraci;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uzrastDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nadimakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource igracDTOBindingSource;
        private System.Windows.Forms.Button cmd_deleteUser;
        private System.Windows.Forms.DataGridView dgv_quest;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpGainDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource questDTOBindingSource;
        private System.Windows.Forms.NumericUpDown num_xpgain;
        private System.Windows.Forms.Button cmd_dodaj_quest;
        private System.Windows.Forms.Label label_xpgain;
        private System.Windows.Forms.Button cmd_delete_quest;
        private System.Windows.Forms.Button cmd_delete_item;
    }
}