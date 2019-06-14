namespace SBP_Projekat.Forme
{
    partial class WelcomeForm
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
            this.cmd_show_registration = new System.Windows.Forms.Button();
            this.cmd_show_login = new System.Windows.Forms.Button();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tb_ime = new System.Windows.Forms.TextBox();
            this.tb_prezime = new System.Windows.Forms.TextBox();
            this.lbl_ime = new System.Windows.Forms.Label();
            this.lbl_prezime = new System.Windows.Forms.Label();
            this.tb_nadimak = new System.Windows.Forms.TextBox();
            this.tb_uzrast = new System.Windows.Forms.TextBox();
            this.lbl_pol = new System.Windows.Forms.Label();
            this.lbl_nadimak = new System.Windows.Forms.Label();
            this.lbl_uzrast = new System.Windows.Forms.Label();
            this.cmd_login = new System.Windows.Forms.Button();
            this.cmd_registration = new System.Windows.Forms.Button();
            this.cb_pol = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmd_show_registration
            // 
            this.cmd_show_registration.BackColor = System.Drawing.Color.LightGray;
            this.cmd_show_registration.FlatAppearance.BorderSize = 0;
            this.cmd_show_registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_show_registration.Location = new System.Drawing.Point(23, 12);
            this.cmd_show_registration.Name = "cmd_show_registration";
            this.cmd_show_registration.Size = new System.Drawing.Size(103, 36);
            this.cmd_show_registration.TabIndex = 0;
            this.cmd_show_registration.Text = "Registracija";
            this.cmd_show_registration.UseVisualStyleBackColor = false;
            this.cmd_show_registration.Click += new System.EventHandler(this.cmd_show_registration_Click);
            // 
            // cmd_show_login
            // 
            this.cmd_show_login.BackColor = System.Drawing.Color.LightGray;
            this.cmd_show_login.FlatAppearance.BorderSize = 0;
            this.cmd_show_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_show_login.Location = new System.Drawing.Point(172, 12);
            this.cmd_show_login.Name = "cmd_show_login";
            this.cmd_show_login.Size = new System.Drawing.Size(103, 36);
            this.cmd_show_login.TabIndex = 0;
            this.cmd_show_login.Text = "Prijavljivanje";
            this.cmd_show_login.UseVisualStyleBackColor = false;
            this.cmd_show_login.Click += new System.EventHandler(this.cmd_show_login_Click);
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(129, 68);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(100, 20);
            this.tb_username.TabIndex = 1;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(61, 71);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(55, 13);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "Username";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(129, 94);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(100, 20);
            this.tb_password.TabIndex = 1;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(61, 97);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(53, 13);
            this.lbl_password.TabIndex = 2;
            this.lbl_password.Text = "Password";
            // 
            // tb_ime
            // 
            this.tb_ime.Location = new System.Drawing.Point(129, 120);
            this.tb_ime.Name = "tb_ime";
            this.tb_ime.Size = new System.Drawing.Size(100, 20);
            this.tb_ime.TabIndex = 1;
            // 
            // tb_prezime
            // 
            this.tb_prezime.Location = new System.Drawing.Point(129, 146);
            this.tb_prezime.Name = "tb_prezime";
            this.tb_prezime.Size = new System.Drawing.Size(100, 20);
            this.tb_prezime.TabIndex = 1;
            // 
            // lbl_ime
            // 
            this.lbl_ime.AutoSize = true;
            this.lbl_ime.Location = new System.Drawing.Point(61, 123);
            this.lbl_ime.Name = "lbl_ime";
            this.lbl_ime.Size = new System.Drawing.Size(24, 13);
            this.lbl_ime.TabIndex = 2;
            this.lbl_ime.Text = "Ime";
            // 
            // lbl_prezime
            // 
            this.lbl_prezime.AutoSize = true;
            this.lbl_prezime.Location = new System.Drawing.Point(61, 149);
            this.lbl_prezime.Name = "lbl_prezime";
            this.lbl_prezime.Size = new System.Drawing.Size(44, 13);
            this.lbl_prezime.TabIndex = 2;
            this.lbl_prezime.Text = "Prezime";
            // 
            // tb_nadimak
            // 
            this.tb_nadimak.Location = new System.Drawing.Point(129, 224);
            this.tb_nadimak.Name = "tb_nadimak";
            this.tb_nadimak.Size = new System.Drawing.Size(100, 20);
            this.tb_nadimak.TabIndex = 1;
            // 
            // tb_uzrast
            // 
            this.tb_uzrast.Location = new System.Drawing.Point(129, 198);
            this.tb_uzrast.Name = "tb_uzrast";
            this.tb_uzrast.Size = new System.Drawing.Size(100, 20);
            this.tb_uzrast.TabIndex = 1;
            // 
            // lbl_pol
            // 
            this.lbl_pol.AutoSize = true;
            this.lbl_pol.Location = new System.Drawing.Point(61, 175);
            this.lbl_pol.Name = "lbl_pol";
            this.lbl_pol.Size = new System.Drawing.Size(22, 13);
            this.lbl_pol.TabIndex = 2;
            this.lbl_pol.Text = "Pol";
            // 
            // lbl_nadimak
            // 
            this.lbl_nadimak.AutoSize = true;
            this.lbl_nadimak.Location = new System.Drawing.Point(61, 227);
            this.lbl_nadimak.Name = "lbl_nadimak";
            this.lbl_nadimak.Size = new System.Drawing.Size(49, 13);
            this.lbl_nadimak.TabIndex = 2;
            this.lbl_nadimak.Text = "Nadimak";
            // 
            // lbl_uzrast
            // 
            this.lbl_uzrast.AutoSize = true;
            this.lbl_uzrast.Location = new System.Drawing.Point(61, 201);
            this.lbl_uzrast.Name = "lbl_uzrast";
            this.lbl_uzrast.Size = new System.Drawing.Size(37, 13);
            this.lbl_uzrast.TabIndex = 2;
            this.lbl_uzrast.Text = "Uzrast";
            // 
            // cmd_login
            // 
            this.cmd_login.BackColor = System.Drawing.Color.LightGray;
            this.cmd_login.FlatAppearance.BorderSize = 0;
            this.cmd_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_login.Location = new System.Drawing.Point(172, 262);
            this.cmd_login.Name = "cmd_login";
            this.cmd_login.Size = new System.Drawing.Size(103, 27);
            this.cmd_login.TabIndex = 0;
            this.cmd_login.Text = "Prijavi me";
            this.cmd_login.UseVisualStyleBackColor = false;
            this.cmd_login.Click += new System.EventHandler(this.cmd_login_Click);
            // 
            // cmd_registration
            // 
            this.cmd_registration.BackColor = System.Drawing.Color.LightGray;
            this.cmd_registration.FlatAppearance.BorderSize = 0;
            this.cmd_registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_registration.Location = new System.Drawing.Point(23, 262);
            this.cmd_registration.Name = "cmd_registration";
            this.cmd_registration.Size = new System.Drawing.Size(103, 27);
            this.cmd_registration.TabIndex = 0;
            this.cmd_registration.Text = "Registracija";
            this.cmd_registration.UseVisualStyleBackColor = false;
            this.cmd_registration.Click += new System.EventHandler(this.cmd_registration_Click);
            // 
            // cb_pol
            // 
            this.cb_pol.FormattingEnabled = true;
            this.cb_pol.Items.AddRange(new object[] {
            "M",
            "Z"});
            this.cb_pol.Location = new System.Drawing.Point(129, 171);
            this.cb_pol.Name = "cb_pol";
            this.cb_pol.Size = new System.Drawing.Size(100, 21);
            this.cb_pol.TabIndex = 3;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 301);
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
            this.Controls.Add(this.cmd_show_login);
            this.Controls.Add(this.cmd_registration);
            this.Controls.Add(this.cmd_login);
            this.Controls.Add(this.cmd_show_registration);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(306, 339);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(306, 339);
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WelcomeForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_show_registration;
        private System.Windows.Forms.Button cmd_show_login;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tb_ime;
        private System.Windows.Forms.TextBox tb_prezime;
        private System.Windows.Forms.Label lbl_ime;
        private System.Windows.Forms.Label lbl_prezime;
        private System.Windows.Forms.TextBox tb_nadimak;
        private System.Windows.Forms.TextBox tb_uzrast;
        private System.Windows.Forms.Label lbl_pol;
        private System.Windows.Forms.Label lbl_nadimak;
        private System.Windows.Forms.Label lbl_uzrast;
        private System.Windows.Forms.Button cmd_login;
        private System.Windows.Forms.Button cmd_registration;
        private System.Windows.Forms.ComboBox cb_pol;
    }
}