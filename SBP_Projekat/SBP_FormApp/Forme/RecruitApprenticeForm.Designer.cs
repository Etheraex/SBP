namespace SBP_Projekat.Forme
{
    partial class RecruitApprenticeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmd_recruit = new System.Windows.Forms.Button();
            this.tb_ime = new System.Windows.Forms.TextBox();
            this.cb_rasa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // cmd_recruit
            // 
            this.cmd_recruit.BackColor = System.Drawing.Color.LightGray;
            this.cmd_recruit.FlatAppearance.BorderSize = 0;
            this.cmd_recruit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_recruit.Location = new System.Drawing.Point(119, 87);
            this.cmd_recruit.Name = "cmd_recruit";
            this.cmd_recruit.Size = new System.Drawing.Size(75, 23);
            this.cmd_recruit.TabIndex = 1;
            this.cmd_recruit.Text = "Regrutuj";
            this.cmd_recruit.UseVisualStyleBackColor = false;
            this.cmd_recruit.Click += new System.EventHandler(this.cmd_recruit_Click);
            // 
            // tb_ime
            // 
            this.tb_ime.Location = new System.Drawing.Point(99, 6);
            this.tb_ime.Name = "tb_ime";
            this.tb_ime.Size = new System.Drawing.Size(100, 20);
            this.tb_ime.TabIndex = 2;
            // 
            // cb_rasa
            // 
            this.cb_rasa.FormattingEnabled = true;
            this.cb_rasa.Items.AddRange(new object[] {
            "Vilenjak",
            "Ork",
            "Covek",
            "Demon",
            "Patuljak"});
            this.cb_rasa.Location = new System.Drawing.Point(78, 32);
            this.cb_rasa.Name = "cb_rasa";
            this.cb_rasa.Size = new System.Drawing.Size(121, 21);
            this.cb_rasa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rasa";
            // 
            // RecruitApprenticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 122);
            this.Controls.Add(this.cb_rasa);
            this.Controls.Add(this.tb_ime);
            this.Controls.Add(this.cmd_recruit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(222, 160);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(222, 160);
            this.Name = "RecruitApprenticeForm";
            this.Text = "RecruitApprenticeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmd_recruit;
        private System.Windows.Forms.TextBox tb_ime;
        private System.Windows.Forms.ComboBox cb_rasa;
        private System.Windows.Forms.Label label2;
    }
}