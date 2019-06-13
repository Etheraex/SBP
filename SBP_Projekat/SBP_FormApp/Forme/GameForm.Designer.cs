namespace SBP_Projekat.Forme
{
    partial class GameForm
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
            this.cmd_giveup = new System.Windows.Forms.Button();
            this.cmd_finish = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Status izvrsenja kvesta";
            // 
            // cmd_giveup
            // 
            this.cmd_giveup.Location = new System.Drawing.Point(12, 76);
            this.cmd_giveup.Name = "cmd_giveup";
            this.cmd_giveup.Size = new System.Drawing.Size(75, 23);
            this.cmd_giveup.TabIndex = 4;
            this.cmd_giveup.Text = "Odustani";
            this.cmd_giveup.UseVisualStyleBackColor = true;
            this.cmd_giveup.Click += new System.EventHandler(this.cmd_giveup_Click);
            // 
            // cmd_finish
            // 
            this.cmd_finish.Location = new System.Drawing.Point(340, 76);
            this.cmd_finish.Name = "cmd_finish";
            this.cmd_finish.Size = new System.Drawing.Size(75, 23);
            this.cmd_finish.TabIndex = 5;
            this.cmd_finish.Text = "Zavrsi";
            this.cmd_finish.UseVisualStyleBackColor = true;
            this.cmd_finish.Click += new System.EventHandler(this.cmd_finish_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(403, 20);
            this.textBox1.TabIndex = 3;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 103);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmd_giveup);
            this.Controls.Add(this.cmd_finish);
            this.Controls.Add(this.textBox1);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmd_giveup;
        private System.Windows.Forms.Button cmd_finish;
        private System.Windows.Forms.TextBox textBox1;
    }
}