namespace SBP_Projekat.Forme
{
    partial class InventoryForm
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
            this.dgv_items = new System.Windows.Forms.DataGridView();
            this.xpBonusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaOruzjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abstractPredmetDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmd_izbaci = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abstractPredmetDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_items
            // 
            this.dgv_items.AllowUserToAddRows = false;
            this.dgv_items.AllowUserToDeleteRows = false;
            this.dgv_items.AllowUserToOrderColumns = true;
            this.dgv_items.AutoGenerateColumns = false;
            this.dgv_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xpBonusDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.vrstaOruzjaDataGridViewTextBoxColumn});
            this.dgv_items.DataSource = this.abstractPredmetDTOBindingSource;
            this.dgv_items.Location = new System.Drawing.Point(12, 12);
            this.dgv_items.Name = "dgv_items";
            this.dgv_items.ReadOnly = true;
            this.dgv_items.Size = new System.Drawing.Size(854, 142);
            this.dgv_items.TabIndex = 0;
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
            this.nazivDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            this.opisDataGridViewTextBoxColumn.Width = 53;
            // 
            // vrstaOruzjaDataGridViewTextBoxColumn
            // 
            this.vrstaOruzjaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vrstaOruzjaDataGridViewTextBoxColumn.DataPropertyName = "VrstaOruzja";
            this.vrstaOruzjaDataGridViewTextBoxColumn.HeaderText = "VrstaOruzja";
            this.vrstaOruzjaDataGridViewTextBoxColumn.Name = "vrstaOruzjaDataGridViewTextBoxColumn";
            this.vrstaOruzjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // abstractPredmetDTOBindingSource
            // 
            this.abstractPredmetDTOBindingSource.DataSource = typeof(SBP_Data.DTOs.AbstractPredmetDTO);
            // 
            // cmd_izbaci
            // 
            this.cmd_izbaci.BackColor = System.Drawing.Color.LightGray;
            this.cmd_izbaci.FlatAppearance.BorderSize = 0;
            this.cmd_izbaci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_izbaci.Location = new System.Drawing.Point(12, 169);
            this.cmd_izbaci.Name = "cmd_izbaci";
            this.cmd_izbaci.Size = new System.Drawing.Size(127, 33);
            this.cmd_izbaci.TabIndex = 4;
            this.cmd_izbaci.Text = "Izbaci predmet";
            this.cmd_izbaci.UseVisualStyleBackColor = false;
            this.cmd_izbaci.Click += new System.EventHandler(this.cmd_izbaci_Click);
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 308);
            this.Controls.Add(this.cmd_izbaci);
            this.Controls.Add(this.dgv_items);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InventoryForm";
            this.Text = "InventoryForm";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abstractPredmetDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_items;
        private System.Windows.Forms.BindingSource abstractPredmetDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpBonusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaOruzjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button cmd_izbaci;
    }
}