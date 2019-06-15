namespace SBP_Projekat.Forme
{
    partial class StatsForm
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
            this.tb_rasa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_hp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_xp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_zlato = new System.Windows.Forms.TextBox();
            this.tb_zamor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rasa";
            // 
            // tb_rasa
            // 
            this.tb_rasa.Location = new System.Drawing.Point(104, 43);
            this.tb_rasa.Name = "tb_rasa";
            this.tb_rasa.ReadOnly = true;
            this.tb_rasa.Size = new System.Drawing.Size(100, 20);
            this.tb_rasa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "HP";
            // 
            // tb_hp
            // 
            this.tb_hp.Location = new System.Drawing.Point(104, 69);
            this.tb_hp.Name = "tb_hp";
            this.tb_hp.ReadOnly = true;
            this.tb_hp.Size = new System.Drawing.Size(100, 20);
            this.tb_hp.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "XP";
            // 
            // tb_xp
            // 
            this.tb_xp.Location = new System.Drawing.Point(104, 95);
            this.tb_xp.Name = "tb_xp";
            this.tb_xp.ReadOnly = true;
            this.tb_xp.Size = new System.Drawing.Size(100, 20);
            this.tb_xp.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Trenutno izabrani lik";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Zlato";
            // 
            // tb_zlato
            // 
            this.tb_zlato.Location = new System.Drawing.Point(104, 121);
            this.tb_zlato.Name = "tb_zlato";
            this.tb_zlato.ReadOnly = true;
            this.tb_zlato.Size = new System.Drawing.Size(100, 20);
            this.tb_zlato.TabIndex = 1;
            // 
            // tb_zamor
            // 
            this.tb_zamor.Location = new System.Drawing.Point(104, 147);
            this.tb_zamor.Name = "tb_zamor";
            this.tb_zamor.ReadOnly = true;
            this.tb_zamor.Size = new System.Drawing.Size(100, 20);
            this.tb_zamor.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Stepen zamora";
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 178);
            this.Controls.Add(this.tb_zamor);
            this.Controls.Add(this.tb_zlato);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_xp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_hp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_rasa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(236, 217);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(236, 217);
            this.Name = "StatsForm";
            this.Text = "Informacije o liku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_rasa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_hp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_xp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_zlato;
        private System.Windows.Forms.TextBox tb_zamor;
        private System.Windows.Forms.Label label6;
    }
}