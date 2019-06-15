namespace SBP_Projekat.Forme
{
    partial class AddItemForm
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
            this.rtb_opis = new System.Windows.Forms.RichTextBox();
            this.cb_tip_predmeta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_rase = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_tip_oruzja = new System.Windows.Forms.TextBox();
            this.cmd_create = new System.Windows.Forms.Button();
            this.error_create_item = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error_create_item)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tip predmeta";
            // 
            // tb_naziv
            // 
            this.tb_naziv.Location = new System.Drawing.Point(52, 39);
            this.tb_naziv.Name = "tb_naziv";
            this.tb_naziv.Size = new System.Drawing.Size(158, 20);
            this.tb_naziv.TabIndex = 1;
            this.tb_naziv.Validating += new System.ComponentModel.CancelEventHandler(this.tb_naziv_Validating);
            // 
            // rtb_opis
            // 
            this.rtb_opis.Location = new System.Drawing.Point(15, 113);
            this.rtb_opis.Name = "rtb_opis";
            this.rtb_opis.Size = new System.Drawing.Size(362, 231);
            this.rtb_opis.TabIndex = 2;
            this.rtb_opis.Text = "";
            this.rtb_opis.Validating += new System.ComponentModel.CancelEventHandler(this.rtb_opis_Validating);
            // 
            // cb_tip_predmeta
            // 
            this.cb_tip_predmeta.FormattingEnabled = true;
            this.cb_tip_predmeta.Items.AddRange(new object[] {
            "Predmet",
            "Oruzje"});
            this.cb_tip_predmeta.Location = new System.Drawing.Point(89, 12);
            this.cb_tip_predmeta.Name = "cb_tip_predmeta";
            this.cb_tip_predmeta.Size = new System.Drawing.Size(121, 21);
            this.cb_tip_predmeta.TabIndex = 3;
            this.cb_tip_predmeta.Validating += new System.ComponentModel.CancelEventHandler(this.cb_tip_predmeta_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Rase koje ga mogu koristiti";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Opis";
            // 
            // cb_rase
            // 
            this.cb_rase.FormattingEnabled = true;
            this.cb_rase.Items.AddRange(new object[] {
            "Patuljak",
            "Ork",
            "Demon",
            "Vilenjak",
            "Covek"});
            this.cb_rase.Location = new System.Drawing.Point(230, 28);
            this.cb_rase.Name = "cb_rase";
            this.cb_rase.Size = new System.Drawing.Size(144, 79);
            this.cb_rase.TabIndex = 4;
            this.cb_rase.Validating += new System.ComponentModel.CancelEventHandler(this.cb_rase_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Vrsta oruzja";
            // 
            // tb_tip_oruzja
            // 
            this.tb_tip_oruzja.Location = new System.Drawing.Point(89, 65);
            this.tb_tip_oruzja.Name = "tb_tip_oruzja";
            this.tb_tip_oruzja.Size = new System.Drawing.Size(121, 20);
            this.tb_tip_oruzja.TabIndex = 1;
            this.tb_tip_oruzja.Validating += new System.ComponentModel.CancelEventHandler(this.tb_tip_oruzja_Validating);
            // 
            // cmd_create
            // 
            this.cmd_create.BackColor = System.Drawing.Color.LightGray;
            this.cmd_create.FlatAppearance.BorderSize = 0;
            this.cmd_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_create.Location = new System.Drawing.Point(299, 351);
            this.cmd_create.Name = "cmd_create";
            this.cmd_create.Size = new System.Drawing.Size(75, 23);
            this.cmd_create.TabIndex = 5;
            this.cmd_create.Text = "Sacuvaj";
            this.cmd_create.UseVisualStyleBackColor = false;
            this.cmd_create.Click += new System.EventHandler(this.cmd_create_Click);
            // 
            // error_create_item
            // 
            this.error_create_item.ContainerControl = this;
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 386);
            this.Controls.Add(this.cmd_create);
            this.Controls.Add(this.cb_rase);
            this.Controls.Add(this.cb_tip_predmeta);
            this.Controls.Add(this.rtb_opis);
            this.Controls.Add(this.tb_tip_oruzja);
            this.Controls.Add(this.tb_naziv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddItemForm";
            this.Text = "AddItem";
            ((System.ComponentModel.ISupportInitialize)(this.error_create_item)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_naziv;
        private System.Windows.Forms.RichTextBox rtb_opis;
        private System.Windows.Forms.ComboBox cb_tip_predmeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox cb_rase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_tip_oruzja;
        private System.Windows.Forms.Button cmd_create;
        private System.Windows.Forms.ErrorProvider error_create_item;
    }
}