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
            this.components = new System.ComponentModel.Container();
            this.cmd_logout = new System.Windows.Forms.Button();
            this.cmd_fullscreen = new System.Windows.Forms.Button();
            this.cmd_minimize = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kuestoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mojProfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izborKarakteraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alijanseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segrtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmd_logout
            // 
            this.cmd_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmd_logout.BackColor = System.Drawing.Color.LightGray;
            this.cmd_logout.FlatAppearance.BorderSize = 0;
            this.cmd_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_logout.Location = new System.Drawing.Point(928, 14);
            this.cmd_logout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmd_logout.Name = "cmd_logout";
            this.cmd_logout.Size = new System.Drawing.Size(167, 33);
            this.cmd_logout.TabIndex = 0;
            this.cmd_logout.Text = "Log out(gasi app)";
            this.cmd_logout.UseVisualStyleBackColor = false;
            this.cmd_logout.Click += new System.EventHandler(this.cmd_logout_Click);
            // 
            // cmd_fullscreen
            // 
            this.cmd_fullscreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmd_fullscreen.BackColor = System.Drawing.Color.LightGray;
            this.cmd_fullscreen.FlatAppearance.BorderSize = 0;
            this.cmd_fullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_fullscreen.Location = new System.Drawing.Point(876, 14);
            this.cmd_fullscreen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.cmd_minimize.Location = new System.Drawing.Point(832, 14);
            this.cmd_minimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmd_minimize.Name = "cmd_minimize";
            this.cmd_minimize.Size = new System.Drawing.Size(36, 33);
            this.cmd_minimize.TabIndex = 0;
            this.cmd_minimize.Text = "➖";
            this.cmd_minimize.UseVisualStyleBackColor = false;
            this.cmd_minimize.Click += new System.EventHandler(this.cmd_minimize_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniToolStripMenuItem,
            this.profilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1108, 63);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniToolStripMenuItem
            // 
            this.meniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kuestoviToolStripMenuItem,
            this.statoviToolStripMenuItem,
            this.inventarToolStripMenuItem,
            this.segrtToolStripMenuItem});
            this.meniToolStripMenuItem.Name = "meniToolStripMenuItem";
            this.meniToolStripMenuItem.Size = new System.Drawing.Size(54, 59);
            this.meniToolStripMenuItem.Text = "Meni";
            // 
            // kuestoviToolStripMenuItem
            // 
            this.kuestoviToolStripMenuItem.Name = "kuestoviToolStripMenuItem";
            this.kuestoviToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.kuestoviToolStripMenuItem.Text = "Kuestovi";
            this.kuestoviToolStripMenuItem.Click += new System.EventHandler(this.kuestoviToolStripMenuItem_Click);
            // 
            // statoviToolStripMenuItem
            // 
            this.statoviToolStripMenuItem.Name = "statoviToolStripMenuItem";
            this.statoviToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.statoviToolStripMenuItem.Text = "Statovi";
            // 
            // inventarToolStripMenuItem
            // 
            this.inventarToolStripMenuItem.Name = "inventarToolStripMenuItem";
            this.inventarToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.inventarToolStripMenuItem.Text = "Inventar";
            this.inventarToolStripMenuItem.Click += new System.EventHandler(this.inventarToolStripMenuItem_Click);
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mojProfilToolStripMenuItem,
            this.izborKarakteraToolStripMenuItem,
            this.alijanseToolStripMenuItem});
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(56, 59);
            this.profilToolStripMenuItem.Text = "Profil";
            // 
            // mojProfilToolStripMenuItem
            // 
            this.mojProfilToolStripMenuItem.Name = "mojProfilToolStripMenuItem";
            this.mojProfilToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.mojProfilToolStripMenuItem.Text = "Moj Profil";
            this.mojProfilToolStripMenuItem.Click += new System.EventHandler(this.mojProfilToolStripMenuItem_Click);
            // 
            // izborKarakteraToolStripMenuItem
            // 
            this.izborKarakteraToolStripMenuItem.Name = "izborKarakteraToolStripMenuItem";
            this.izborKarakteraToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.izborKarakteraToolStripMenuItem.Text = "Izbor Karaktera";
            this.izborKarakteraToolStripMenuItem.Click += new System.EventHandler(this.izborKarakteraToolStripMenuItem_Click);
            // 
            // alijanseToolStripMenuItem
            // 
            this.alijanseToolStripMenuItem.Name = "alijanseToolStripMenuItem";
            this.alijanseToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.alijanseToolStripMenuItem.Text = "Alijanse";
            this.alijanseToolStripMenuItem.Click += new System.EventHandler(this.alijanseToolStripMenuItem_Click);
            // 
            // segrtToolStripMenuItem
            // 
            this.segrtToolStripMenuItem.Name = "segrtToolStripMenuItem";
            this.segrtToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.segrtToolStripMenuItem.Text = "Segrt";
            this.segrtToolStripMenuItem.Click += new System.EventHandler(this.segrtToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1108, 612);
            this.Controls.Add(this.cmd_logout);
            this.Controls.Add(this.cmd_fullscreen);
            this.Controls.Add(this.cmd_minimize);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_logout;
        private System.Windows.Forms.Button cmd_fullscreen;
        private System.Windows.Forms.Button cmd_minimize;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kuestoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mojProfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izborKarakteraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alijanseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segrtToolStripMenuItem;
    }
}

