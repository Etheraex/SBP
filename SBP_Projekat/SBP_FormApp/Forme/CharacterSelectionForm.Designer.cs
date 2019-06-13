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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.likDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zlatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stepenZamoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zlatoDataGridViewTextBoxColumn,
            this.hPDataGridViewTextBoxColumn,
            this.xPDataGridViewTextBoxColumn,
            this.stepenZamoraDataGridViewTextBoxColumn,
            this.rasaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.likDTOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(545, 255);
            this.dataGridView1.TabIndex = 4;
            // 
            // likDTOBindingSource
            // 
            this.likDTOBindingSource.DataSource = typeof(SBP_Data.DTOs.LikDTO);
            // 
            // zlatoDataGridViewTextBoxColumn
            // 
            this.zlatoDataGridViewTextBoxColumn.DataPropertyName = "Zlato";
            this.zlatoDataGridViewTextBoxColumn.HeaderText = "Zlato";
            this.zlatoDataGridViewTextBoxColumn.Name = "zlatoDataGridViewTextBoxColumn";
            this.zlatoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hPDataGridViewTextBoxColumn
            // 
            this.hPDataGridViewTextBoxColumn.DataPropertyName = "HP";
            this.hPDataGridViewTextBoxColumn.HeaderText = "HP";
            this.hPDataGridViewTextBoxColumn.Name = "hPDataGridViewTextBoxColumn";
            this.hPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xPDataGridViewTextBoxColumn
            // 
            this.xPDataGridViewTextBoxColumn.DataPropertyName = "XP";
            this.xPDataGridViewTextBoxColumn.HeaderText = "XP";
            this.xPDataGridViewTextBoxColumn.Name = "xPDataGridViewTextBoxColumn";
            this.xPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stepenZamoraDataGridViewTextBoxColumn
            // 
            this.stepenZamoraDataGridViewTextBoxColumn.DataPropertyName = "StepenZamora";
            this.stepenZamoraDataGridViewTextBoxColumn.HeaderText = "StepenZamora";
            this.stepenZamoraDataGridViewTextBoxColumn.Name = "stepenZamoraDataGridViewTextBoxColumn";
            this.stepenZamoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rasaDataGridViewTextBoxColumn
            // 
            this.rasaDataGridViewTextBoxColumn.DataPropertyName = "Rasa";
            this.rasaDataGridViewTextBoxColumn.HeaderText = "Rasa";
            this.rasaDataGridViewTextBoxColumn.Name = "rasaDataGridViewTextBoxColumn";
            this.rasaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CharacterSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 391);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmd_select);
            this.Controls.Add(this.cmd_delete);
            this.Controls.Add(this.cmd_napravi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CharacterSelection";
            this.Text = "CharacterSelection";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.likDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_napravi;
        private System.Windows.Forms.Button cmd_delete;
        private System.Windows.Forms.Button cmd_select;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zlatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepenZamoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource likDTOBindingSource;
    }
}