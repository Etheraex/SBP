using SBP_Data;
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
    public partial class AdminForm : Form
    {
        private Form _login;
        public AdminForm(Form l)
        {
            InitializeComponent();
            _login = l;
            dgv_predmeti.Visible = false;
            dgv_sesije.Visible = false;
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _login.Show();
        }

        private void raseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void predmetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_predmeti.Visible = true;
            var tmp = DTOManager.Instance.GetAllItems();
            dgv_predmeti.DataSource = tmp;
        }

        private void sesijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_sesije.Visible = true;
            var tmp = DTOManager.Instance.GetAllSessions();
            dgv_sesije.DataSource = tmp;
        }
    }
}
