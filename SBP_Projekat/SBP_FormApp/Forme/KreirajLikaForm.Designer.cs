namespace SBP_Projekat.Forme
{
    partial class KreirajLikaForm
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
            this.cb_rasa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_hp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_stepen_zamora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmd_kreiraj = new System.Windows.Forms.Button();
            this.error_create_character = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error_create_character)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_rasa
            // 
            this.cb_rasa.FormattingEnabled = true;
            this.cb_rasa.Location = new System.Drawing.Point(112, 12);
            this.cb_rasa.Name = "cb_rasa";
            this.cb_rasa.Size = new System.Drawing.Size(121, 21);
            this.cb_rasa.TabIndex = 0;
            this.cb_rasa.Validating += new System.ComponentModel.CancelEventHandler(this.cb_rasa_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izaberite rasu";
            // 
            // tb_hp
            // 
            this.tb_hp.Location = new System.Drawing.Point(133, 39);
            this.tb_hp.Name = "tb_hp";
            this.tb_hp.Size = new System.Drawing.Size(100, 20);
            this.tb_hp.TabIndex = 2;
            this.tb_hp.Validating += new System.ComponentModel.CancelEventHandler(this.tb_hp_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "HP";
            // 
            // tb_stepen_zamora
            // 
            this.tb_stepen_zamora.Location = new System.Drawing.Point(133, 65);
            this.tb_stepen_zamora.Name = "tb_stepen_zamora";
            this.tb_stepen_zamora.Size = new System.Drawing.Size(100, 20);
            this.tb_stepen_zamora.TabIndex = 2;
            this.tb_stepen_zamora.Validating += new System.ComponentModel.CancelEventHandler(this.tb_stepen_zamora_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Stepen zamora";
            // 
            // cmd_kreiraj
            // 
            this.cmd_kreiraj.BackColor = System.Drawing.Color.LightGray;
            this.cmd_kreiraj.FlatAppearance.BorderSize = 0;
            this.cmd_kreiraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_kreiraj.Location = new System.Drawing.Point(158, 107);
            this.cmd_kreiraj.Name = "cmd_kreiraj";
            this.cmd_kreiraj.Size = new System.Drawing.Size(75, 23);
            this.cmd_kreiraj.TabIndex = 3;
            this.cmd_kreiraj.Text = "Kreiraj";
            this.cmd_kreiraj.UseVisualStyleBackColor = false;
            this.cmd_kreiraj.Click += new System.EventHandler(this.cmd_kreiraj_Click);
            // 
            // error_create_character
            // 
            this.error_create_character.ContainerControl = this;
            // 
            // KreirajLikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 135);
            this.Controls.Add(this.cmd_kreiraj);
            this.Controls.Add(this.tb_stepen_zamora);
            this.Controls.Add(this.tb_hp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_rasa);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KreirajLikaForm";
            this.Text = "KreirajLikaForm";
            ((System.ComponentModel.ISupportInitialize)(this.error_create_character)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_rasa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_hp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_stepen_zamora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmd_kreiraj;
        private System.Windows.Forms.ErrorProvider error_create_character;
    }
}