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
            this.xpGainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmd_fullscreen = new System.Windows.Forms.Button();
            this.cmd_odradi_quest = new System.Windows.Forms.Button();
            this.cmd_saAlijansom = new System.Windows.Forms.Button();
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
            this.dgv_quest.Location = new System.Drawing.Point(16, 137);
            this.dgv_quest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_quest.Name = "dgv_quest";
            this.dgv_quest.ReadOnly = true;
            this.dgv_quest.Size = new System.Drawing.Size(247, 490);
            this.dgv_quest.TabIndex = 0;
            // 
            // xpGainDataGridViewTextBoxColumn
            // 
            this.xpGainDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xpGainDataGridViewTextBoxColumn.DataPropertyName = "XpGain";
            this.xpGainDataGridViewTextBoxColumn.HeaderText = "XpGain";
            this.xpGainDataGridViewTextBoxColumn.Name = "xpGainDataGridViewTextBoxColumn";
            this.xpGainDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.cmd_fullscreen.Location = new System.Drawing.Point(16, 15);
            this.cmd_fullscreen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmd_fullscreen.Name = "cmd_fullscreen";
            this.cmd_fullscreen.Size = new System.Drawing.Size(172, 33);
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
            this.cmd_odradi_quest.Location = new System.Drawing.Point(16, 55);
            this.cmd_odradi_quest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmd_odradi_quest.Name = "cmd_odradi_quest";
            this.cmd_odradi_quest.Size = new System.Drawing.Size(172, 33);
            this.cmd_odradi_quest.TabIndex = 1;
            this.cmd_odradi_quest.Text = "Zapocni zadatak";
            this.cmd_odradi_quest.UseVisualStyleBackColor = false;
            this.cmd_odradi_quest.Click += new System.EventHandler(this.cmd_odradi_quest_Click);
            // 
            // cmd_saAlijansom
            // 
            this.cmd_saAlijansom.BackColor = System.Drawing.Color.LightGray;
            this.cmd_saAlijansom.FlatAppearance.BorderSize = 0;
            this.cmd_saAlijansom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_saAlijansom.Location = new System.Drawing.Point(16, 96);
            this.cmd_saAlijansom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmd_saAlijansom.Name = "cmd_saAlijansom";
            this.cmd_saAlijansom.Size = new System.Drawing.Size(241, 33);
            this.cmd_saAlijansom.TabIndex = 1;
            this.cmd_saAlijansom.Text = "Zapocni zadatak sa alijansom";
            this.cmd_saAlijansom.UseVisualStyleBackColor = false;
            this.cmd_saAlijansom.Click += new System.EventHandler(this.button2_Click);
            // 
            // QuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 630);
            this.Controls.Add(this.cmd_saAlijansom);
            this.Controls.Add(this.cmd_odradi_quest);
            this.Controls.Add(this.cmd_fullscreen);
            this.Controls.Add(this.dgv_quest);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(294, 677);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(294, 677);
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
        private System.Windows.Forms.Button cmd_saAlijansom;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpGainDataGridViewTextBoxColumn;
    }
}