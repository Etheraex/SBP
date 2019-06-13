namespace SBP_Projekat.Forme
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
            this.cmd_fullscreen = new System.Windows.Forms.Button();
            this.cmd_minimize = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmd_logout
            // 
            this.cmd_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmd_logout.BackColor = System.Drawing.Color.LightGray;
            this.cmd_logout.FlatAppearance.BorderSize = 0;
            this.cmd_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_logout.Location = new System.Drawing.Point(915, 12);
            this.cmd_logout.Margin = new System.Windows.Forms.Padding(4);
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
            this.panel1.Controls.Add(this.cmd_fullscreen);
            this.panel1.Controls.Add(this.cmd_minimize);
            this.panel1.Controls.Add(this.cmd_logout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 60);
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
            this.cmd_profile.Location = new System.Drawing.Point(12, 12);
            this.cmd_profile.Margin = new System.Windows.Forms.Padding(4);
            this.cmd_profile.Name = "cmd_profile";
            this.cmd_profile.Size = new System.Drawing.Size(167, 33);
            this.cmd_profile.TabIndex = 0;
            this.cmd_profile.Text = "Moj profil";
            this.cmd_profile.UseVisualStyleBackColor = false;
            this.cmd_profile.Click += new System.EventHandler(this.cmd_profile_Click);
            // 
            // cmd_fullscreen
            // 
            this.cmd_fullscreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmd_fullscreen.BackColor = System.Drawing.Color.LightGray;
            this.cmd_fullscreen.FlatAppearance.BorderSize = 0;
            this.cmd_fullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_fullscreen.Location = new System.Drawing.Point(861, 12);
            this.cmd_fullscreen.Margin = new System.Windows.Forms.Padding(4);
            this.cmd_fullscreen.Name = "cmd_fullscreen";
            this.cmd_fullscreen.Size = new System.Drawing.Size(44, 33);
            this.cmd_fullscreen.TabIndex = 0;
            this.cmd_fullscreen.Text = "🔲";
            this.cmd_fullscreen.UseVisualStyleBackColor = false;
            this.cmd_fullscreen.Click += new System.EventHandler(this.cmd_fullScreen_Click);
            // 
            // cmd_minimize
            // 
            this.cmd_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmd_minimize.BackColor = System.Drawing.Color.LightGray;
            this.cmd_minimize.FlatAppearance.BorderSize = 0;
            this.cmd_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_minimize.Location = new System.Drawing.Point(817, 12);
            this.cmd_minimize.Margin = new System.Windows.Forms.Padding(4);
            this.cmd_minimize.Name = "cmd_minimize";
            this.cmd_minimize.Size = new System.Drawing.Size(36, 33);
            this.cmd_minimize.TabIndex = 0;
            this.cmd_minimize.Text = "➖";
            this.cmd_minimize.UseVisualStyleBackColor = false;
            this.cmd_minimize.Click += new System.EventHandler(this.cmd_minimize_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1108, 612);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
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
        private System.Windows.Forms.Button cmd_fullscreen;
        private System.Windows.Forms.Button cmd_minimize;
    }
}

