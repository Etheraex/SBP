namespace SBP_Projekat.Forme
{
    partial class ApprenticeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmd_odbaci = new System.Windows.Forms.Button();
            this.cmd_recruit = new System.Windows.Forms.Button();
            this.dgv_my_apprentice = new System.Windows.Forms.DataGridView();
            this.zlatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stepenZamoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.likDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_my_apprentice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.likDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vas segrt";
            // 
            // cmd_odbaci
            // 
            this.cmd_odbaci.BackColor = System.Drawing.Color.LightGray;
            this.cmd_odbaci.FlatAppearance.BorderSize = 0;
            this.cmd_odbaci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_odbaci.Location = new System.Drawing.Point(593, 36);
            this.cmd_odbaci.Name = "cmd_odbaci";
            this.cmd_odbaci.Size = new System.Drawing.Size(121, 23);
            this.cmd_odbaci.TabIndex = 3;
            this.cmd_odbaci.Text = "Odbaci segrta";
            this.cmd_odbaci.UseVisualStyleBackColor = false;
            this.cmd_odbaci.Click += new System.EventHandler(this.cmd_odbaci_Click);
            // 
            // cmd_recruit
            // 
            this.cmd_recruit.BackColor = System.Drawing.Color.LightGray;
            this.cmd_recruit.FlatAppearance.BorderSize = 0;
            this.cmd_recruit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_recruit.Location = new System.Drawing.Point(593, 96);
            this.cmd_recruit.Name = "cmd_recruit";
            this.cmd_recruit.Size = new System.Drawing.Size(121, 23);
            this.cmd_recruit.TabIndex = 3;
            this.cmd_recruit.Text = "Regrutuj segrta";
            this.cmd_recruit.UseVisualStyleBackColor = false;
            this.cmd_recruit.Click += new System.EventHandler(this.cmd_recruit_Click);
            // 
            // dgv_my_apprentice
            // 
            this.dgv_my_apprentice.AllowUserToAddRows = false;
            this.dgv_my_apprentice.AllowUserToDeleteRows = false;
            this.dgv_my_apprentice.AutoGenerateColumns = false;
            this.dgv_my_apprentice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_my_apprentice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zlatoDataGridViewTextBoxColumn,
            this.hPDataGridViewTextBoxColumn,
            this.xPDataGridViewTextBoxColumn,
            this.stepenZamoraDataGridViewTextBoxColumn});
            this.dgv_my_apprentice.DataSource = this.likDTOBindingSource;
            this.dgv_my_apprentice.Location = new System.Drawing.Point(12, 36);
            this.dgv_my_apprentice.Name = "dgv_my_apprentice";
            this.dgv_my_apprentice.ReadOnly = true;
            this.dgv_my_apprentice.Size = new System.Drawing.Size(545, 83);
            this.dgv_my_apprentice.TabIndex = 4;
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
            // likDTOBindingSource
            // 
            this.likDTOBindingSource.DataSource = typeof(SBP_Data.DTOs.LikDTO);
            // 
            // ApprenticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 148);
            this.Controls.Add(this.dgv_my_apprentice);
            this.Controls.Add(this.cmd_recruit);
            this.Controls.Add(this.cmd_odbaci);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApprenticeForm";
            this.Text = "Segrti";
            this.Load += new System.EventHandler(this.ApprenticeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_my_apprentice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.likDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmd_odbaci;
        private System.Windows.Forms.Button cmd_recruit;
        private System.Windows.Forms.DataGridView dgv_my_apprentice;
        private System.Windows.Forms.BindingSource likDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn zlatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepenZamoraDataGridViewTextBoxColumn;
    }
}