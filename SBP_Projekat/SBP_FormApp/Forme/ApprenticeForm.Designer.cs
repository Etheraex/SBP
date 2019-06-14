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
            this.dgv_my = new System.Windows.Forms.DataGridView();
            this.dgv_free = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmd_uzmi_novog = new System.Windows.Forms.Button();
            this.cmd_odbaci = new System.Windows.Forms.Button();
            this.imeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rasaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.likDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segrtDTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.likDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segrtDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_my)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_free)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segrtDTOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segrtDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_my
            // 
            this.dgv_my.AllowUserToAddRows = false;
            this.dgv_my.AllowUserToDeleteRows = false;
            this.dgv_my.AutoGenerateColumns = false;
            this.dgv_my.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_my.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imeDataGridViewTextBoxColumn,
            this.bonusDataGridViewTextBoxColumn,
            this.rasaDataGridViewTextBoxColumn,
            this.likDataGridViewTextBoxColumn});
            this.dgv_my.DataSource = this.segrtDTOBindingSource;
            this.dgv_my.Location = new System.Drawing.Point(12, 36);
            this.dgv_my.Name = "dgv_my";
            this.dgv_my.ReadOnly = true;
            this.dgv_my.Size = new System.Drawing.Size(443, 45);
            this.dgv_my.TabIndex = 0;
            // 
            // dgv_free
            // 
            this.dgv_free.AllowUserToAddRows = false;
            this.dgv_free.AllowUserToDeleteRows = false;
            this.dgv_free.AutoGenerateColumns = false;
            this.dgv_free.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_free.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imeDataGridViewTextBoxColumn1,
            this.bonusDataGridViewTextBoxColumn1,
            this.rasaDataGridViewTextBoxColumn1,
            this.likDataGridViewTextBoxColumn1});
            this.dgv_free.DataSource = this.segrtDTOBindingSource1;
            this.dgv_free.Location = new System.Drawing.Point(12, 143);
            this.dgv_free.Name = "dgv_free";
            this.dgv_free.ReadOnly = true;
            this.dgv_free.Size = new System.Drawing.Size(443, 134);
            this.dgv_free.TabIndex = 1;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dostupni segrti";
            // 
            // cmd_uzmi_novog
            // 
            this.cmd_uzmi_novog.Location = new System.Drawing.Point(497, 143);
            this.cmd_uzmi_novog.Name = "cmd_uzmi_novog";
            this.cmd_uzmi_novog.Size = new System.Drawing.Size(121, 23);
            this.cmd_uzmi_novog.TabIndex = 3;
            this.cmd_uzmi_novog.Text = "Uzmi novog segrta";
            this.cmd_uzmi_novog.UseVisualStyleBackColor = true;
            this.cmd_uzmi_novog.Click += new System.EventHandler(this.cmd_uzmi_novog_Click);
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
            // imeDataGridViewTextBoxColumn1
            // 
            this.imeDataGridViewTextBoxColumn1.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn1.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn1.Name = "imeDataGridViewTextBoxColumn1";
            this.imeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bonusDataGridViewTextBoxColumn1
            // 
            this.bonusDataGridViewTextBoxColumn1.DataPropertyName = "Bonus";
            this.bonusDataGridViewTextBoxColumn1.HeaderText = "Bonus";
            this.bonusDataGridViewTextBoxColumn1.Name = "bonusDataGridViewTextBoxColumn1";
            this.bonusDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // rasaDataGridViewTextBoxColumn1
            // 
            this.rasaDataGridViewTextBoxColumn1.DataPropertyName = "Rasa";
            this.rasaDataGridViewTextBoxColumn1.HeaderText = "Rasa";
            this.rasaDataGridViewTextBoxColumn1.Name = "rasaDataGridViewTextBoxColumn1";
            this.rasaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // likDataGridViewTextBoxColumn1
            // 
            this.likDataGridViewTextBoxColumn1.DataPropertyName = "Lik";
            this.likDataGridViewTextBoxColumn1.HeaderText = "Lik";
            this.likDataGridViewTextBoxColumn1.Name = "likDataGridViewTextBoxColumn1";
            this.likDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // segrtDTOBindingSource1
            // 
            this.segrtDTOBindingSource1.DataSource = typeof(SBP_Data.DTOs.SegrtDTO);
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
            // ApprenticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmd_odbaci);
            this.Controls.Add(this.cmd_uzmi_novog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_free);
            this.Controls.Add(this.dgv_my);
            this.Name = "ApprenticeForm";
            this.Text = "ApprenticeForm";
            this.Load += new System.EventHandler(this.ApprenticeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_my)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_free)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segrtDTOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segrtDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_my;
        private System.Windows.Forms.BindingSource segrtDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn likDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgv_free;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rasaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn likDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource segrtDTOBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmd_uzmi_novog;
        private System.Windows.Forms.Button cmd_odbaci;
    }
}