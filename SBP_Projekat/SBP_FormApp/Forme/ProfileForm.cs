using SBP_Data;
using SBP_Data.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBP_Projekat.Forme
{
    public partial class ProfileForm : Form
    {
        IgracDTO _igrac;
        public ProfileForm(IgracDTO igrac,MainForm parent)
        {
            this.MdiParent = parent;
            InitializeComponent();
            _igrac = igrac;
            tb_ime.Text = igrac.Ime;
            tb_prezime.Text = igrac.Prezime;
            tb_username.Text = igrac.Username;
            tb_uzrast.Text = igrac.Uzrast.ToString();
            tb_password.Text = igrac.Password.ToString();
            tb_nadimak.Text = igrac.Nadimak;
            if (igrac.Pol == 'M')
                cb_pol.SelectedIndex = 1;
            else
                cb_pol.SelectedIndex = 0;
        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {

            DialogResult check = MessageBox.Show("Da li ste sigurni da zelite da obrisete profil?","Upozorenje", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (check == DialogResult.Yes)
            {
                DTOManager.Instance.DeleteEntity<IgracDTO>(_igrac);

                MdiParent.Close();
            }

        }
    }
}
