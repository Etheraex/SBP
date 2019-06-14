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
            this.dgv_my_apprentice = new System.Windows.Forms.DataGridView();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.likDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segrtDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cmd_odbaci = new System.Windows.Forms.Button();
            this.segrtDTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmd_recruit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_my_apprentice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segrtDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segrtDTOBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_my_apprentice
            // 
            this.dgv_my_apprentice.AllowUserToAddRows = false;
            this.dgv_my_apprentice.AllowUserToDeleteRows = false;
            this.dgv_my_apprentice.AutoGenerateColumns = false;
            this.dgv_my_apprentice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_my_apprentice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imeDataGridViewTextBoxColumn,
            this.bonusDataGridViewTextBoxColumn,
            this.rasaDataGridViewTextBoxColumn,
            this.likDataGridViewTextBoxColumn});
            this.dgv_my_apprentice.DataSource = this.segrtDTOBindingSource;
            this.dgv_my_apprentice.Location = new System.Drawing.Point(12, 36);
            this.dgv_my_apprentice.Name = "dgv_my_apprentice";
            this.dgv_my_apprentice.ReadOnly = true;
            this.dgv_my_apprentice.Size = new System.Drawing.Size(443, 83);
            this.dgv_my_apprentice.TabIndex = 0;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bonusDataGridViewTextBoxColumn
            // 
            this.bonusDataGridViewTextBoxColumn.DataPropertyName = "Bonus";
            this.bonusDataGridViewTextBoxColumn.HeaderText = "Bonus";
            this.bonusDataGridViewTextBoxColumn.Name = "bonusDataGridViewTextBoxColumn";
            this.bonusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rasaDataGridViewTextBoxColumn
            // 
            this.rasaDataGridViewTextBoxColumn.DataPropertyName = "Rasa";
            this.rasaDataGridViewTextBoxColumn.HeaderText = "Rasa";
            this.rasaDataGridViewTextBoxColumn.Name = "rasaDataGridViewTextBoxColumn";
            this.rasaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // likDataGridViewTextBoxColumn
            // 
            this.likDataGridViewTextBoxColumn.DataPropertyName = "Lik";
            this.likDataGridViewTextBoxColumn.HeaderText = "Lik";
            this.likDataGridViewTextBoxColumn.Name = "likDataGridViewTextBoxColumn";
            this.likDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // segrtDTOBindingSource
            // 
            this.segrtDTOBindingSource.DataSource = typeof(SBP_Data.DTOs.SegrtDTO);
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
            this.cmd_odbaci.Location = new System.Drawing.Point(497, 36);
            this.cmd_odbaci.Name = "cmd_odbaci";
            this.cmd_odbaci.Size = new System.Drawing.Size(121, 23);
            this.cmd_odbaci.TabIndex = 3;
            this.cmd_odbaci.Text = "Odbaci segrta";
            this.cmd_odbaci.UseVisualStyleBackColor = true;
            this.cmd_odbaci.Click += new System.EventHandler(this.cmd_odbaci_Click);
            // 
            // segrtDTOBindingSource1
            // 
            this.segrtDTOBindingSource1.DataSource = typeof(SBP_Data.DTOs.SegrtDTO);
            // 
            // cmd_recruit
            // 
            this.cmd_recruit.Location = new System.Drawing.Point(497, 96);
            this.cmd_recruit.Name = "cmd_recruit";
            this.cmd_recruit.Size = new System.Drawing.Size(121, 23);
            this.cmd_recruit.TabIndex = 3;
            this.cmd_recruit.Text = "Regrutuj segrta";
            this.cmd_recruit.UseVisualStyleBackColor = true;
            this.cmd_recruit.Click += new System.EventHandler(this.cmd_recruit_Click);
            // 
            // ApprenticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 148);
            this.Controls.Add(this.cmd_recruit);
            this.Controls.Add(this.cmd_odbaci);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_my_apprentice);
            this.Name = "ApprenticeForm";
            this.Text = "ApprenticeForm";
            this.Load += new System.EventHandler(this.ApprenticeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_my_apprentice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segrtDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segrtDTOBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_my_apprentice;
        private System.Windows.Forms.BindingSource segrtDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn likDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource segrtDTOBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmd_odbaci;
        private System.Windows.Forms.Button cmd_recruit;
    }
}