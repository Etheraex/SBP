using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SBP_Data;
using SBP_Data.Models;
using SBP_Data.DTOs;
using System.Security.Cryptography;

namespace SBP_Projekat.Forme
{
    public partial class WelcomeForm : Form
    {
        private MainForm _mainForm;
        public WelcomeForm()
        {
            InitializeComponent();
            cmd_registration.Visible = false;
            tb_ime.Visible = false;
            tb_prezime.Visible = false;
            tb_nadimak.Visible = false;
            cb_pol.Visible = false;
            nud_uzrast.Visible = false;
            lbl_ime.Visible = false;
            lbl_nadimak.Visible = false;
            lbl_pol.Visible = false;
            lbl_prezime.Visible = false;
            lbl_uzrast.Visible = false;
            _mainForm = new MainForm(this);
        }
        private MainForm LoadMainForm()
        {
            _mainForm= new MainForm(this);
            return _mainForm;
        }
        private void cmd_show_registration_Click(object sender, EventArgs e)
        {
            cmd_registration.Visible = true;
            cmd_login.Visible = false;
            tb_ime.Visible = true;
            tb_prezime.Visible = true;
            tb_nadimak.Visible = true;
            cb_pol.Visible = true;
            nud_uzrast.Visible = true;
            lbl_ime.Visible = true;
            lbl_nadimak.Visible = true;
            lbl_pol.Visible = true;
            lbl_prezime.Visible = true;
            lbl_uzrast.Visible = true;
        }

        private void cmd_registration_Click(object sender, EventArgs e)
        {
            if (!ValidateAll())
                return;
            // char.Parse(cb_pol.SelectedText) Ovo nesto zajebava pa sam ovako stavi
            var tmp = cb_pol.SelectedItem.ToString();
            char tmpPol;
            if (tmp == "M")
                tmpPol = 'm';
            else
                tmpPol = 'z';
            
            var igrac = new IgracDTO
            {
                Username = tb_username.Text,
                Password = tb_password.Text,
                Nadimak = tb_nadimak.Text,
                Pol = tmpPol,
                Uzrast = (int)nud_uzrast.Value,
                Ime = tb_ime.Text,
                Prezime = tb_prezime.Text
            };
            DTOManager.Instance.SaveEntity(igrac);
            LoadMainForm();
            _mainForm.SetPlayer(igrac);

            this.Hide();
            _mainForm.Show();
        }

        private void cmd_show_login_Click(object sender, EventArgs e)
        {
            cmd_registration.Visible = false;
            cmd_login.Visible = true;
            tb_ime.Visible = false;
            tb_prezime.Visible = false;
            tb_nadimak.Visible = false;
            cb_pol.Visible = false;
            nud_uzrast.Visible = false;
            lbl_ime.Visible = false;
            lbl_nadimak.Visible = false;
            lbl_pol.Visible = false;
            lbl_prezime.Visible = false;
            lbl_uzrast.Visible = false;
        }

        private void cmd_login_Click(object sender, EventArgs e)
        {
            if (!ValidateUsername() || !ValidatePassword())
                return;
            var result = DTOManager.Instance.LogIn(tb_username.Text, tb_password.Text, out IgracDTO igrac);
            if (result == 0)
                MessageBox.Show("Nepostojeci igrac");
            else if (result == 1)
                MessageBox.Show("Pogresna sifra");
            else
            {
                LoadMainForm();
                _mainForm.SetPlayer(igrac);
                this.Hide();
                _mainForm.Show();
            }
        }

        private void WelcomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        #region Validacija

        public bool ValidateAll()
        {
            if (!ValidateIme() || !ValidateNadimak() || !ValidatePol() || !ValidatePrezime() || !ValidatePassword() || !ValidateUsername())
                return false;
            return true;
        }

        private void tb_ime_Validating(object sender, CancelEventArgs e)
        {
            ValidateIme();
        }

        private void tb_prezime_Validating(object sender, CancelEventArgs e)
        {
            ValidatePrezime();
        }

        private void cb_pol_Validating(object sender, CancelEventArgs e)
        {
            ValidatePol();
        }

        private void tb_nadimak_Validating(object sender, CancelEventArgs e)
        {
            ValidateNadimak();
        }
        
        public bool ValidatePol()
        {
            if(cb_pol.SelectedIndex == -1)
            {
                error_welcome.SetError(cb_pol, "Morate izabrati pol");
                return false;
            }
            return true;
        }

        private void tb_username_Validating(object sender, CancelEventArgs e)
        {
            ValidateUsername();
        }

        private void tb_password_Validating(object sender, CancelEventArgs e)
        {
            ValidatePassword();
        }

        public bool ValidatePassword()
        {
            if (tb_password.Text == "")
            {
                error_welcome.SetError(tb_password, "Morate uneti password");
                return false;
            }
            return true;
        }

        public bool ValidateUsername()
        {
            if (tb_username.Text == "")
            {
                error_welcome.SetError(tb_username, "Morate uneti username");
                return false;
            }
            return true;
        }

        public bool ValidateNadimak()
        {
            if (tb_nadimak.Text == "")
            {
                error_welcome.SetError(tb_nadimak, "Morate uneti nadimak");
                return false;
            }
            else if (tb_nadimak.Text.Any(char.IsDigit))
            {
                error_welcome.SetError(tb_nadimak, "Nadimak ne sme sadrzati brojeve");
                return false;
            }
            return true;
        }

        public bool ValidateIme()
        {
            if(tb_ime.Text == "")
            {
                error_welcome.SetError(tb_ime, "Morate uneti ime");
                return false;
            }
            else if(tb_ime.Text.Any(char.IsDigit))
            {
                error_welcome.SetError(tb_ime, "Ime ne sme sadrzati brojeve");
                return false;
            }
            return true;
        }

        public bool ValidatePrezime()
        {
            if (tb_prezime.Text == "")
            {
                error_welcome.SetError(tb_prezime, "Morate uneti prezime");
                return false;
            }
            else if (tb_prezime.Text.Any(char.IsDigit))
            {
                error_welcome.SetError(tb_prezime, "Prezime ne sme sadrzati brojeve");
                return false;
            }
            return true;
        }

        #endregion

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new AdminForm(this);
            form.Show();
            this.Hide();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            DTOManager.Instance.InitTest();
        }

        
    }
}
