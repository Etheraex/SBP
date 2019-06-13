namespace SBP_Projekat.Forme
{
    partial class AlianceForm
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
            this.dgvAlijanse = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lAlijansa = new System.Windows.Forms.Label();
            this.btnLeave = new System.Windows.Forms.Button();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minBrojIgracaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxBrojIgracaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xpBonusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hpBonusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alijansaDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnJoin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlijanse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alijansaDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlijanse
            // 
            this.dgvAlijanse.AllowUserToAddRows = false;
            this.dgvAlijanse.AllowUserToDeleteRows = false;
            this.dgvAlijanse.AllowUserToOrderColumns = true;
            this.dgvAlijanse.AllowUserToResizeColumns = false;
            this.dgvAlijanse.AllowUserToResizeRows = false;
            this.dgvAlijanse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAlijanse.AutoGenerateColumns = false;
            this.dgvAlijanse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAlijanse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAlijanse.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvAlijanse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlijanse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivDataGridViewTextBoxColumn,
            this.minBrojIgracaDataGridViewTextBoxColumn,
            this.maxBrojIgracaDataGridViewTextBoxColumn,
            this.xpBonusDataGridViewTextBoxColumn,
            this.hpBonusDataGridViewTextBoxColumn});
            this.dgvAlijanse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvAlijanse.DataSource = this.alijansaDTOBindingSource;
            this.dgvAlijanse.Location = new System.Drawing.Point(3, 3);
            this.dgvAlijanse.MultiSelect = false;
            this.dgvAlijanse.Name = "dgvAlijanse";
            this.dgvAlijanse.ReadOnly = true;
            this.dgvAlijanse.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAlijanse.Size = new System.Drawing.Size(522, 136);
            this.dgvAlijanse.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trenutno ste u alijansi:";
            this.label1.Visible = false;
            // 
            // lAlijansa
            // 
            this.lAlijansa.AutoSize = true;
            this.lAlijansa.Location = new System.Drawing.Point(536, 41);
            this.lAlijansa.Name = "lAlijansa";
            this.lAlijansa.Size = new System.Drawing.Size(0, 13);
            this.lAlijansa.TabIndex = 2;
            this.lAlijansa.Visible = false;
            // 
            // btnLeave
            // 
            this.btnLeave.Location = new System.Drawing.Point(539, 76);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(110, 23);
            this.btnLeave.TabIndex = 3;
            this.btnLeave.Text = "Napustite alijansu";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.cmd_Leave_Click);
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // minBrojIgracaDataGridViewTextBoxColumn
            // 
            this.minBrojIgracaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.minBrojIgracaDataGridViewTextBoxColumn.DataPropertyName = "MinBrojIgraca";
            this.minBrojIgracaDataGridViewTextBoxColumn.HeaderText = "Minimalni broj igraca";
            this.minBrojIgracaDataGridViewTextBoxColumn.Name = "minBrojIgracaDataGridViewTextBoxColumn";
            this.minBrojIgracaDataGridViewTextBoxColumn.ReadOnly = true;
            this.minBrojIgracaDataGridViewTextBoxColumn.Width = 90;
            // 
            // maxBrojIgracaDataGridViewTextBoxColumn
            // 
            this.maxBrojIgracaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.maxBrojIgracaDataGridViewTextBoxColumn.DataPropertyName = "MaxBrojIgraca";
            this.maxBrojIgracaDataGridViewTextBoxColumn.HeaderText = "Maksimalni broj igraca";
            this.maxBrojIgracaDataGridViewTextBoxColumn.Name = "maxBrojIgracaDataGridViewTextBoxColumn";
            this.maxBrojIgracaDataGridViewTextBoxColumn.ReadOnly = true;
            this.maxBrojIgracaDataGridViewTextBoxColumn.Width = 98;
            // 
            // xpBonusDataGridViewTextBoxColumn
            // 
            this.xpBonusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.xpBonusDataGridViewTextBoxColumn.DataPropertyName = "XpBonus";
            this.xpBonusDataGridViewTextBoxColumn.HeaderText = "XP bonus";
            this.xpBonusDataGridViewTextBoxColumn.Name = "xpBonusDataGridViewTextBoxColumn";
            this.xpBonusDataGridViewTextBoxColumn.ReadOnly = true;
            this.xpBonusDataGridViewTextBoxColumn.Width = 72;
            // 
            // hpBonusDataGridViewTextBoxColumn
            // 
            this.hpBonusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.hpBonusDataGridViewTextBoxColumn.DataPropertyName = "HpBonus";
            this.hpBonusDataGridViewTextBoxColumn.HeaderText = "HP bonus";
            this.hpBonusDataGridViewTextBoxColumn.Name = "hpBonusDataGridViewTextBoxColumn";
            this.hpBonusDataGridViewTextBoxColumn.ReadOnly = true;
            this.hpBonusDataGridViewTextBoxColumn.Width = 73;
            // 
            // alijansaDTOBindingSource
            // 
            this.alijansaDTOBindingSource.DataSource = typeof(SBP_Data.DTOs.AlijansaDTO);
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(32, 175);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(169, 23);
            this.btnJoin.TabIndex = 4;
            this.btnJoin.Text = "Uclani se u izabranu alijansu";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.cmd_Join_Click);
            // 
            // AlianceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 219);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.lAlijansa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAlijanse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(700, 250);
            this.Name = "AlianceForm";
            this.Text = "AlianceF";
            this.Load += new System.EventHandler(this.AlianceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlijanse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alijansaDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlijanse;
        private System.Windows.Forms.BindingSource alijansaDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minBrojIgracaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxBrojIgracaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpBonusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hpBonusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lAlijansa;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Button btnJoin;
    }
}