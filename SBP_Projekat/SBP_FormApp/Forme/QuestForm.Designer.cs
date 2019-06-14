namespace SBP_Projekat.Forme
{
    partial class QuestForm
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
            this.dgv_quest = new System.Windows.Forms.DataGridView();
            this.questDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmd_fullscreen = new System.Windows.Forms.Button();
            this.cmd_odradi_quest = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.xpGainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_quest
            // 
            this.dgv_quest.AllowUserToAddRows = false;
            this.dgv_quest.AllowUserToDeleteRows = false;
            this.dgv_quest.AutoGenerateColumns = false;
            this.dgv_quest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_quest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xpGainDataGridViewTextBoxColumn});
            this.dgv_quest.DataSource = this.questDTOBindingSource;
            this.dgv_quest.Location = new System.Drawing.Point(12, 111);
            this.dgv_quest.Name = "dgv_quest";
            this.dgv_quest.ReadOnly = true;
            this.dgv_quest.Size = new System.Drawing.Size(185, 398);
            this.dgv_quest.TabIndex = 0;
            // 
            // questDTOBindingSource
            // 
            this.questDTOBindingSource.DataSource = typeof(SBP_Data.DTOs.QuestDTO);
            // 
            // cmd_fullscreen
            // 
            this.cmd_fullscreen.BackColor = System.Drawing.Color.LightGray;
            this.cmd_fullscreen.FlatAppearance.BorderSize = 0;
            this.cmd_fullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_fullscreen.Location = new System.Drawing.Point(12, 12);
            this.cmd_fullscreen.Name = "cmd_fullscreen";
            this.cmd_fullscreen.Size = new System.Drawing.Size(129, 27);
            this.cmd_fullscreen.TabIndex = 1;
            this.cmd_fullscreen.Text = "Vidi potrebne predmete";
            this.cmd_fullscreen.UseVisualStyleBackColor = false;
            this.cmd_fullscreen.Click += new System.EventHandler(this.cmd_questItems_Click);
            // 
            // cmd_odradi_quest
            // 
            this.cmd_odradi_quest.BackColor = System.Drawing.Color.LightGray;
            this.cmd_odradi_quest.FlatAppearance.BorderSize = 0;
            this.cmd_odradi_quest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_odradi_quest.Location = new System.Drawing.Point(12, 45);
            this.cmd_odradi_quest.Name = "cmd_odradi_quest";
            this.cmd_odradi_quest.Size = new System.Drawing.Size(129, 27);
            this.cmd_odradi_quest.TabIndex = 1;
            this.cmd_odradi_quest.Text = "Zapocni zadatak";
            this.cmd_odradi_quest.UseVisualStyleBackColor = false;
            this.cmd_odradi_quest.Click += new System.EventHandler(this.cmd_odradi_quest_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "Zapocni zadatak sa alijansom";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // xpGainDataGridViewTextBoxColumn
            // 
            this.xpGainDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xpGainDataGridViewTextBoxColumn.DataPropertyName = "XpGain";
            this.xpGainDataGridViewTextBoxColumn.HeaderText = "XpGain";
            this.xpGainDataGridViewTextBoxColumn.Name = "xpGainDataGridViewTextBoxColumn";
            this.xpGainDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // QuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 521);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmd_odradi_quest);
            this.Controls.Add(this.cmd_fullscreen);
            this.Controls.Add(this.dgv_quest);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(225, 559);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(225, 559);
            this.Name = "QuestForm";
            this.Text = "QuestForm";
            this.Load += new System.EventHandler(this.QuestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_quest;
        private System.Windows.Forms.BindingSource questDTOBindingSource;
        private System.Windows.Forms.Button cmd_fullscreen;
        private System.Windows.Forms.Button cmd_odradi_quest;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpGainDataGridViewTextBoxColumn;
    }
}