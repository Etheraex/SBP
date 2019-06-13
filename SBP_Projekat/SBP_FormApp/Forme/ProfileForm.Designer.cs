namespace SBP_Projekat.Forme
{
    partial class ProfileForm
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
            this.cb_pol = new System.Windows.Forms.ComboBox();
            this.lbl_prezime = new System.Windows.Forms.Label();
            this.lbl_uzrast = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_nadimak = new System.Windows.Forms.Label();
            this.lbl_ime = new System.Windows.Forms.Label();
            this.lbl_pol = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.tb_prezime = new System.Windows.Forms.TextBox();
            this.tb_uzrast = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_nadimak = new System.Windows.Forms.TextBox();
            this.tb_ime = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_pol
            // 
            this.cb_pol.FormattingEnabled = true;
            this.cb_pol.Items.AddRange(new object[] {
            "M",
            "Z"});
            this.cb_pol.Location = new System.Drawing.Point(107, 134);
            this.cb_pol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_pol.Name = "cb_pol";
            this.cb_pol.Size = new System.Drawing.Size(132, 24);
            this.cb_pol.TabIndex = 17;
            // 
            // lbl_prezime
            // 
            this.lbl_prezime.AutoSize = true;
            this.lbl_prezime.Location = new System.Drawing.Point(16, 107);
            this.lbl_prezime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_prezime.Name = "lbl_prezime";
            this.lbl_prezime.Size = new System.Drawing.Size(59, 17);
            this.lbl_prezime.TabIndex = 10;
            this.lbl_prezime.Text = "Prezime";
            // 
            // lbl_uzrast
            // 
            this.lbl_uzrast.AutoSize = true;
            this.lbl_uzrast.Location = new System.Drawing.Point(16, 171);
            this.lbl_uzrast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_uzrast.Name = "lbl_uzrast";
            this.lbl_uzrast.Size = new System.Drawing.Size(49, 17);
            this.lbl_uzrast.TabIndex = 11;
            this.lbl_uzrast.Text = "Uzrast";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(16, 43);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(69, 17);
            this.lbl_password.TabIndex = 12;
            this.lbl_password.Text = "Password";
            // 
            // lbl_nadimak
            // 
            this.lbl_nadimak.AutoSize = true;
            this.lbl_nadimak.Location = new System.Drawing.Point(16, 203);
            this.lbl_nadimak.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nadimak.Name = "lbl_nadimak";
            this.lbl_nadimak.Size = new System.Drawing.Size(63, 17);
            this.lbl_nadimak.TabIndex = 13;
            this.lbl_nadimak.Text = "Nadimak";
            // 
            // lbl_ime
            // 
            this.lbl_ime.AutoSize = true;
            this.lbl_ime.Location = new System.Drawing.Point(16, 75);
            this.lbl_ime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ime.Name = "lbl_ime";
            this.lbl_ime.Size = new System.Drawing.Size(30, 17);
            this.lbl_ime.TabIndex = 14;
            this.lbl_ime.Text = "Ime";
            // 
            // lbl_pol
            // 
            this.lbl_pol.AutoSize = true;
            this.lbl_pol.Location = new System.Drawing.Point(16, 139);
            this.lbl_pol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pol.Name = "lbl_pol";
            this.lbl_pol.Size = new System.Drawing.Size(28, 17);
            this.lbl_pol.TabIndex = 15;
            this.lbl_pol.Text = "Pol";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(16, 11);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(73, 17);
            this.lbl_username.TabIndex = 16;
            this.lbl_username.Text = "Username";
            // 
            // tb_prezime
            // 
            this.tb_prezime.Location = new System.Drawing.Point(107, 103);
            this.tb_prezime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_prezime.Name = "tb_prezime";
            this.tb_prezime.ReadOnly = true;
            this.tb_prezime.Size = new System.Drawing.Size(132, 22);
            this.tb_prezime.TabIndex = 4;
            // 
            // tb_uzrast
            // 
            this.tb_uzrast.Location = new System.Drawing.Point(107, 167);
            this.tb_uzrast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_uzrast.Name = "tb_uzrast";
            this.tb_uzrast.ReadOnly = true;
            this.tb_uzrast.Size = new System.Drawing.Size(132, 22);
            this.tb_uzrast.TabIndex = 5;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(107, 39);
            this.tb_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_password.Name = "tb_password";
            this.tb_password.ReadOnly = true;
            this.tb_password.Size = new System.Drawing.Size(132, 22);
            this.tb_password.TabIndex = 6;
            // 
            // tb_nadimak
            // 
            this.tb_nadimak.Location = new System.Drawing.Point(107, 199);
            this.tb_nadimak.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_nadimak.Name = "tb_nadimak";
            this.tb_nadimak.ReadOnly = true;
            this.tb_nadimak.Size = new System.Drawing.Size(132, 22);
            this.tb_nadimak.TabIndex = 7;
            // 
            // tb_ime
            // 
            this.tb_ime.Location = new System.Drawing.Point(107, 71);
            this.tb_ime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_ime.Name = "tb_ime";
            this.tb_ime.ReadOnly = true;
            this.tb_ime.Size = new System.Drawing.Size(132, 22);
            this.tb_ime.TabIndex = 8;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(107, 7);
            this.tb_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_username.Name = "tb_username";
            this.tb_username.ReadOnly = true;
            this.tb_username.Size = new System.Drawing.Size(132, 22);
            this.tb_username.TabIndex = 9;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 271);
            this.Controls.Add(this.cb_pol);
            this.Controls.Add(this.lbl_prezime);
            this.Controls.Add(this.lbl_uzrast);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_nadimak);
            this.Controls.Add(this.lbl_ime);
            this.Controls.Add(this.lbl_pol);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.tb_prezime);
            this.Controls.Add(this.tb_uzrast);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_nadimak);
            this.Controls.Add(this.tb_ime);
            this.Controls.Add(this.tb_username);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_pol;
        private System.Windows.Forms.Label lbl_prezime;
        private System.Windows.Forms.Label lbl_uzrast;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_nadimak;
        private System.Windows.Forms.Label lbl_ime;
        private System.Windows.Forms.Label lbl_pol;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox tb_prezime;
        private System.Windows.Forms.TextBox tb_uzrast;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_nadimak;
        private System.Windows.Forms.TextBox tb_ime;
        private System.Windows.Forms.TextBox tb_username;
    }
}