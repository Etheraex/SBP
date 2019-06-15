namespace SBP_Projekat.Forme
{
    partial class CreateAlianceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_naziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_min = new System.Windows.Forms.NumericUpDown();
            this.nud_max = new System.Windows.Forms.NumericUpDown();
            this.cmd_create = new System.Windows.Forms.Button();
            this.error_create_aliance = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nud_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_create_aliance)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // tb_naziv
            // 
            this.tb_naziv.Location = new System.Drawing.Point(112, 12);
            this.tb_naziv.Name = "tb_naziv";
            this.tb_naziv.Size = new System.Drawing.Size(100, 20);
            this.tb_naziv.TabIndex = 1;
            this.tb_naziv.Validating += new System.ComponentModel.CancelEventHandler(this.tb_naziv_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Minimalno igraca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Maksimalno igraca";
            // 
            // nud_min
            // 
            this.nud_min.Location = new System.Drawing.Point(112, 47);
            this.nud_min.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_min.Name = "nud_min";
            this.nud_min.Size = new System.Drawing.Size(120, 20);
            this.nud_min.TabIndex = 2;
            this.nud_min.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_min.Validating += new System.ComponentModel.CancelEventHandler(this.nud_min_Validating);
            // 
            // nud_max
            // 
            this.nud_max.Location = new System.Drawing.Point(113, 79);
            this.nud_max.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_max.Name = "nud_max";
            this.nud_max.Size = new System.Drawing.Size(120, 20);
            this.nud_max.TabIndex = 2;
            this.nud_max.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_max.Validating += new System.ComponentModel.CancelEventHandler(this.nud_max_Validating);
            // 
            // cmd_create
            // 
            this.cmd_create.BackColor = System.Drawing.Color.LightGray;
            this.cmd_create.FlatAppearance.BorderSize = 0;
            this.cmd_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_create.Location = new System.Drawing.Point(110, 136);
            this.cmd_create.Name = "cmd_create";
            this.cmd_create.Size = new System.Drawing.Size(122, 23);
            this.cmd_create.TabIndex = 5;
            this.cmd_create.Text = "Napravi";
            this.cmd_create.UseVisualStyleBackColor = false;
            this.cmd_create.Click += new System.EventHandler(this.cmd_create_Click);
            // 
            // error_create_aliance
            // 
            this.error_create_aliance.ContainerControl = this;
            // 
            // CreateAlianceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 388);
            this.Controls.Add(this.cmd_create);
            this.Controls.Add(this.nud_max);
            this.Controls.Add(this.nud_min);
            this.Controls.Add(this.tb_naziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateAlianceForm";
            this.Text = "Kreiranje alijanse";
            ((System.ComponentModel.ISupportInitialize)(this.nud_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_create_aliance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_naziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_min;
        private System.Windows.Forms.NumericUpDown nud_max;
        private System.Windows.Forms.Button cmd_create;
        private System.Windows.Forms.ErrorProvider error_create_aliance;
    }
}