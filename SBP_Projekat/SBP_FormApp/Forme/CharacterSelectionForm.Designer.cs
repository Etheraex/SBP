namespace SBP_Projekat.Forme
{
    partial class CharacterSelectionForm
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
            this.cmd_napravi = new System.Windows.Forms.Button();
            this.cmd_delete = new System.Windows.Forms.Button();
            this.cmd_select = new System.Windows.Forms.Button();
            this.dgv_likovi_dd = new System.Windows.Forms.DataGridView();
            this.NormalizedRasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zlatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stepenZamoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.likDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_likovi_dd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.likDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_napravi
            // 
            this.cmd_napravi.BackColor = System.Drawing.Color.LightGray;
            this.cmd_napravi.FlatAppearance.BorderSize = 0;
            this.cmd_napravi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_napravi.Location = new System.Drawing.Point(9, 225);
            this.cmd_napravi.Margin = new System.Windows.Forms.Padding(2);
            this.cmd_napravi.Name = "cmd_napravi";
            this.cmd_napravi.Size = new System.Drawing.Size(125, 40);
            this.cmd_napravi.TabIndex = 1;
            this.cmd_napravi.Text = "Napravi";
            this.cmd_napravi.UseVisualStyleBackColor = false;
            this.cmd_napravi.Click += new System.EventHandler(this.cmd_napravi_Click);
            // 
            // cmd_delete
            // 
            this.cmd_delete.BackColor = System.Drawing.Color.LightGray;
            this.cmd_delete.FlatAppearance.BorderSize = 0;
            this.cmd_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_delete.Location = new System.Drawing.Point(9, 270);
            this.cmd_delete.Margin = new System.Windows.Forms.Padding(2);
            this.cmd_delete.Name = "cmd_delete";
            this.cmd_delete.Size = new System.Drawing.Size(125, 40);
            this.cmd_delete.TabIndex = 2;
            this.cmd_delete.Text = "Obrisi";
            this.cmd_delete.UseVisualStyleBackColor = false;
            this.cmd_delete.Click += new System.EventHandler(this.cmd_delete_Click);
            // 
            // cmd_select
            // 
            this.cmd_select.BackColor = System.Drawing.Color.LightGray;
            this.cmd_select.FlatAppearance.BorderSize = 0;
            this.cmd_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_select.Location = new System.Drawing.Point(385, 267);
            this.cmd_select.Margin = new System.Windows.Forms.Padding(2);
            this.cmd_select.Name = "cmd_select";
            this.cmd_select.Size = new System.Drawing.Size(125, 40);
            this.cmd_select.TabIndex = 3;
            this.cmd_select.Text = "Izaberi lika";
            this.cmd_select.UseVisualStyleBackColor = false;
            this.cmd_select.Click += new System.EventHandler(this.cmd_select_Click);
            // 
            // dgv_likovi_dd
            // 
            this.dgv_likovi_dd.AllowUserToDeleteRows = false;
            this.dgv_likovi_dd.AutoGenerateColumns = false;
            this.dgv_likovi_dd.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_likovi_dd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_likovi_dd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NormalizedRasa,
            this.xPDataGridViewTextBoxColumn,
            this.hPDataGridViewTextBoxColumn,
            this.zlatoDataGridViewTextBoxColumn,
            this.stepenZamoraDataGridViewTextBoxColumn});
            this.dgv_likovi_dd.DataSource = this.likDTOBindingSource;
            this.dgv_likovi_dd.Location = new System.Drawing.Point(9, 10);
            this.dgv_likovi_dd.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_likovi_dd.Name = "dgv_likovi_dd";
            this.dgv_likovi_dd.ReadOnly = true;
            this.dgv_likovi_dd.RowTemplate.Height = 24;
            this.dgv_likovi_dd.Size = new System.Drawing.Size(501, 207);
            this.dgv_likovi_dd.TabIndex = 4;
            // 
            // NormalizedRasa
            // 
            this.NormalizedRasa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NormalizedRasa.DataPropertyName = "NormalizedRasa";
            this.NormalizedRasa.HeaderText = "NormalizedRasa";
            this.NormalizedRasa.Name = "NormalizedRasa";
            this.NormalizedRasa.ReadOnly = true;
            // 
            // xPDataGridViewTextBoxColumn
            // 
            this.xPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xPDataGridViewTextBoxColumn.DataPropertyName = "XP";
            this.xPDataGridViewTextBoxColumn.HeaderText = "XP";
            this.xPDataGridViewTextBoxColumn.Name = "xPDataGridViewTextBoxColumn";
            this.xPDataGridViewTextBoxColumn.ReadOnly = true;
            this.xPDataGridViewTextBoxColumn.Width = 46;
            // 
            // hPDataGridViewTextBoxColumn
            // 
            this.hPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hPDataGridViewTextBoxColumn.DataPropertyName = "HP";
            this.hPDataGridViewTextBoxColumn.HeaderText = "HP";
            this.hPDataGridViewTextBoxColumn.Name = "hPDataGridViewTextBoxColumn";
            this.hPDataGridViewTextBoxColumn.ReadOnly = true;
            this.hPDataGridViewTextBoxColumn.Width = 47;
            // 
            // zlatoDataGridViewTextBoxColumn
            // 
            this.zlatoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.zlatoDataGridViewTextBoxColumn.DataPropertyName = "Zlato";
            this.zlatoDataGridViewTextBoxColumn.HeaderText = "Zlato";
            this.zlatoDataGridViewTextBoxColumn.Name = "zlatoDataGridViewTextBoxColumn";
            this.zlatoDataGridViewTextBoxColumn.ReadOnly = true;
            this.zlatoDataGridViewTextBoxColumn.Width = 56;
            // 
            // stepenZamoraDataGridViewTextBoxColumn
            // 
            this.stepenZamoraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.stepenZamoraDataGridViewTextBoxColumn.DataPropertyName = "StepenZamora";
            this.stepenZamoraDataGridViewTextBoxColumn.HeaderText = "StepenZamora";
            this.stepenZamoraDataGridViewTextBoxColumn.Name = "stepenZamoraDataGridViewTextBoxColumn";
            this.stepenZamoraDataGridViewTextBoxColumn.ReadOnly = true;
            this.stepenZamoraDataGridViewTextBoxColumn.Width = 102;
            // 
            // likDTOBindingSource
            // 
            this.likDTOBindingSource.DataSource = typeof(SBP_Data.DTOs.LikDTO);
            // 
            // CharacterSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 318);
            this.Controls.Add(this.dgv_likovi_dd);
            this.Controls.Add(this.cmd_select);
            this.Controls.Add(this.cmd_delete);
            this.Controls.Add(this.cmd_napravi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CharacterSelectionForm";
            this.Text = "CharacterSelection";
            this.Load += new System.EventHandler(this.CharacterSelectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_likovi_dd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.likDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_napravi;
        private System.Windows.Forms.Button cmd_delete;
        private System.Windows.Forms.Button cmd_select;
        private System.Windows.Forms.DataGridView dgv_likovi_dd;
        private System.Windows.Forms.BindingSource likDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn NormalizedRasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zlatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepenZamoraDataGridViewTextBoxColumn;
    }
}