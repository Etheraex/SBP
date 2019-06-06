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

namespace SBP_Projekat
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
            cmd_login.Visible = false;
        }

        private void cmd_show_registration_Click(object sender, EventArgs e)
        {
            cmd_registration.Visible = true;
            cmd_login.Visible = false;
            tb_ime.Visible = true;
            tb_prezime.Visible = true;
            tb_nadimak.Visible = true;
            cb_pol.Visible = true;
            tb_uzrast.Visible = true;
            lbl_ime.Visible = true;
            lbl_nadimak.Visible = true;
            lbl_pol.Visible = true;
            lbl_prezime.Visible = true;
            lbl_uzrast.Visible = true;
        }

        private void cmd_registration_Click(object sender, EventArgs e)
        {
            // char.Parse(cb_pol.SelectedText) Ovo nesto zajebava pa sam ovako stavi
            var tmp = cb_pol.SelectedItem.ToString();
            char tmpPol;
            if (tmp == "M")
                tmpPol = 'm';
            else
                tmpPol = 'z';

            var HashSifra = ComputeSha256Hash(tb_password.Text);
            MessageBox.Show(HashSifra);
            var igrac = new IgracDTO
            {
                Username = tb_username.Text,
                // Password = HashSifra,
                Password = tb_password.Text,
                Nadimak = tb_nadimak.Text,
                Pol = tmpPol,
                Uzrast = int.Parse(tb_uzrast.Text),
                Ime = tb_ime.Text,
                Prezime = tb_prezime.Text
            };
            DTOManager.Instance.SaveEntity(igrac);
        }

        private void cmd_show_login_Click(object sender, EventArgs e)
        {
            cmd_registration.Visible = false;
            cmd_login.Visible = true;
            tb_ime.Visible = false;
            tb_prezime.Visible = false;
            tb_nadimak.Visible = false;
            cb_pol.Visible = false;
            tb_uzrast.Visible = false;
            lbl_ime.Visible = false;
            lbl_nadimak.Visible = false;
            lbl_pol.Visible = false;
            lbl_prezime.Visible = false;
            lbl_uzrast.Visible = false;
        }

        private void cmd_login_Click(object sender, EventArgs e)
        {
            // var HashSifra = ComputeSha256Hash(tb_password.Text);
            var result = DTOManager.Instance.LogIn(tb_username.Text, tb_password.Text, out IgracDTO igrac);
            if (result == 0)
                MessageBox.Show("Nepostojeci igrac");
            else if (result == 1)
                MessageBox.Show("Pogresna sifra");
            else
                MessageBox.Show(igrac.Ime + " " + igrac.Prezime);
        }

        private string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
