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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.dgv_likovi_dd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.likDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_napravi
            // 
            this.cmd_napravi.Location = new System.Drawing.Point(12, 277);
            this.cmd_napravi.Name = "cmd_napravi";
            this.cmd_napravi.Size = new System.Drawing.Size(167, 49);
            this.cmd_napravi.TabIndex = 1;
            this.cmd_napravi.Text = "Napravi";
            this.cmd_napravi.UseVisualStyleBackColor = true;
            // 
            // cmd_delete
            // 
            this.cmd_delete.Enabled = false;
            this.cmd_delete.Location = new System.Drawing.Point(12, 332);
            this.cmd_delete.Name = "cmd_delete";
            this.cmd_delete.Size = new System.Drawing.Size(167, 49);
            this.cmd_delete.TabIndex = 2;
            this.cmd_delete.Text = "Obrisi";
            this.cmd_delete.UseVisualStyleBackColor = true;
            // 
            // cmd_select
            // 
            this.cmd_select.Enabled = false;
            this.cmd_select.Location = new System.Drawing.Point(390, 330);
            this.cmd_select.Name = "cmd_select";
            this.cmd_select.Size = new System.Drawing.Size(167, 49);
            this.cmd_select.TabIndex = 3;
            this.cmd_select.Text = "Izaberi lika";
            this.cmd_select.UseVisualStyleBackColor = true;
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
            this.dgv_likovi_dd.Location = new System.Drawing.Point(12, 12);
            this.dgv_likovi_dd.Name = "dgv_likovi_dd";
            this.dgv_likovi_dd.ReadOnly = true;
            this.dgv_likovi_dd.RowTemplate.Height = 24;
            this.dgv_likovi_dd.Size = new System.Drawing.Size(627, 255);
            this.dgv_likovi_dd.TabIndex = 4;
            // 
            // NormalizedRasa
            // 
            this.NormalizedRasa.DataPropertyName = "NormalizedRasa";
            this.NormalizedRasa.HeaderText = "NormalizedRasa";
            this.NormalizedRasa.Name = "NormalizedRasa";
            this.NormalizedRasa.ReadOnly = true;
            // 
            // xPDataGridViewTextBoxColumn
            // 
            this.xPDataGridViewTextBoxColumn.DataPropertyName = "XP";
            this.xPDataGridViewTextBoxColumn.HeaderText = "XP";
            this.xPDataGridViewTextBoxColumn.Name = "xPDataGridViewTextBoxColumn";
            this.xPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hPDataGridViewTextBoxColumn
            // 
            this.hPDataGridViewTextBoxColumn.DataPropertyName = "HP";
            this.hPDataGridViewTextBoxColumn.HeaderText = "HP";
            this.hPDataGridViewTextBoxColumn.Name = "hPDataGridViewTextBoxColumn";
            this.hPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zlatoDataGridViewTextBoxColumn
            // 
            this.zlatoDataGridViewTextBoxColumn.DataPropertyName = "Zlato";
            this.zlatoDataGridViewTextBoxColumn.HeaderText = "Zlato";
            this.zlatoDataGridViewTextBoxColumn.Name = "zlatoDataGridViewTextBoxColumn";
            this.zlatoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stepenZamoraDataGridViewTextBoxColumn
            // 
            this.stepenZamoraDataGridViewTextBoxColumn.DataPropertyName = "StepenZamora";
            this.stepenZamoraDataGridViewTextBoxColumn.HeaderText = "StepenZamora";
            this.stepenZamoraDataGridViewTextBoxColumn.Name = "stepenZamoraDataGridViewTextBoxColumn";
            this.stepenZamoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // likDTOBindingSource
            // 
            this.likDTOBindingSource.DataSource = typeof(SBP_Data.DTOs.LikDTO);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Location = new System.Drawing.Point(727, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(367, 227);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "NormalizedRasa";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 109;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 116;
            // 
            // CharacterSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 391);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dgv_likovi_dd);
            this.Controls.Add(this.cmd_select);
            this.Controls.Add(this.cmd_delete);
            this.Controls.Add(this.cmd_napravi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CharacterSelectionForm";
            this.Text = "CharacterSelection";
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}