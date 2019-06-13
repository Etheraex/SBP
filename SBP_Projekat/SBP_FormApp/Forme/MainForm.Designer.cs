﻿namespace SBP_Projekat.Forme
{
    partial class MainForm
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
            this.cmd_logout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmd_profile = new System.Windows.Forms.Button();
            this.cmd_prikazi_likove = new System.Windows.Forms.Button();
            this.rtb_likovi = new System.Windows.Forms.RichTextBox();
            this.cmd_napravi_lika = new System.Windows.Forms.Button();
            this.cmd_zapocni_igru = new System.Windows.Forms.Button();
            this.lb_likovi = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmd_logout
            // 
            this.cmd_logout.BackColor = System.Drawing.Color.LightGray;
            this.cmd_logout.FlatAppearance.BorderSize = 0;
            this.cmd_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_logout.Location = new System.Drawing.Point(616, 14);
            this.cmd_logout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmd_logout.Name = "cmd_logout";
            this.cmd_logout.Size = new System.Drawing.Size(167, 33);
            this.cmd_logout.TabIndex = 0;
            this.cmd_logout.Text = "Log out(gasi app)";
            this.cmd_logout.UseVisualStyleBackColor = false;
            this.cmd_logout.Click += new System.EventHandler(this.cmd_logout_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmd_profile);
            this.panel1.Controls.Add(this.cmd_logout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // cmd_profile
            // 
            this.cmd_profile.BackColor = System.Drawing.Color.LightGray;
            this.cmd_profile.FlatAppearance.BorderSize = 0;
            this.cmd_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_profile.Location = new System.Drawing.Point(429, 14);
            this.cmd_profile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmd_profile.Name = "cmd_profile";
            this.cmd_profile.Size = new System.Drawing.Size(167, 33);
            this.cmd_profile.TabIndex = 0;
            this.cmd_profile.Text = "Moj profil";
            this.cmd_profile.UseVisualStyleBackColor = false;
            this.cmd_profile.Click += new System.EventHandler(this.cmd_profile_Click);
            // 
            // cmd_prikazi_likove
            // 
            this.cmd_prikazi_likove.BackColor = System.Drawing.Color.LightGray;
            this.cmd_prikazi_likove.FlatAppearance.BorderSize = 0;
            this.cmd_prikazi_likove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_prikazi_likove.Location = new System.Drawing.Point(0, 68);
            this.cmd_prikazi_likove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmd_prikazi_likove.Name = "cmd_prikazi_likove";
            this.cmd_prikazi_likove.Size = new System.Drawing.Size(167, 33);
            this.cmd_prikazi_likove.TabIndex = 0;
            this.cmd_prikazi_likove.Text = "Prikaze moje likove";
            this.cmd_prikazi_likove.UseVisualStyleBackColor = false;
            this.cmd_prikazi_likove.Click += new System.EventHandler(this.cmd_prikazi_likove_Click);
            // 
            // rtb_likovi
            // 
            this.rtb_likovi.Location = new System.Drawing.Point(0, 108);
            this.rtb_likovi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtb_likovi.Name = "rtb_likovi";
            this.rtb_likovi.Size = new System.Drawing.Size(271, 158);
            this.rtb_likovi.TabIndex = 2;
            this.rtb_likovi.Text = "";
            // 
            // cmd_napravi_lika
            // 
            this.cmd_napravi_lika.BackColor = System.Drawing.Color.LightGray;
            this.cmd_napravi_lika.FlatAppearance.BorderSize = 0;
            this.cmd_napravi_lika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_napravi_lika.Location = new System.Drawing.Point(0, 274);
            this.cmd_napravi_lika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmd_napravi_lika.Name = "cmd_napravi_lika";
            this.cmd_napravi_lika.Size = new System.Drawing.Size(115, 33);
            this.cmd_napravi_lika.TabIndex = 0;
            this.cmd_napravi_lika.Text = "Kreiraj novog lika";
            this.cmd_napravi_lika.UseVisualStyleBackColor = false;
            this.cmd_napravi_lika.Click += new System.EventHandler(this.cmd_napravi_lika_Click);
            // 
            // cmd_zapocni_igru
            // 
            this.cmd_zapocni_igru.Location = new System.Drawing.Point(122, 274);
            this.cmd_zapocni_igru.Name = "cmd_zapocni_igru";
            this.cmd_zapocni_igru.Size = new System.Drawing.Size(149, 33);
            this.cmd_zapocni_igru.TabIndex = 4;
            this.cmd_zapocni_igru.Text = "Zapocni igru";
            this.cmd_zapocni_igru.UseVisualStyleBackColor = true;
            this.cmd_zapocni_igru.Click += new System.EventHandler(this.cmd_zapocni_igru_Click);
            // 
            // lb_likovi
            // 
            this.lb_likovi.FormattingEnabled = true;
            this.lb_likovi.ItemHeight = 16;
            this.lb_likovi.Location = new System.Drawing.Point(305, 115);
            this.lb_likovi.Name = "lb_likovi";
            this.lb_likovi.Size = new System.Drawing.Size(251, 148);
            this.lb_likovi.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.lb_likovi);
            this.Controls.Add(this.cmd_zapocni_igru);
            this.Controls.Add(this.rtb_likovi);
            this.Controls.Add(this.cmd_napravi_lika);
            this.Controls.Add(this.cmd_prikazi_likove);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_logout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmd_profile;
        private System.Windows.Forms.Button cmd_prikazi_likove;
        private System.Windows.Forms.RichTextBox rtb_likovi;
        private System.Windows.Forms.Button cmd_napravi_lika;
        private System.Windows.Forms.Button cmd_zapocni_igru;
        private System.Windows.Forms.ListBox lb_likovi;
    }
}

