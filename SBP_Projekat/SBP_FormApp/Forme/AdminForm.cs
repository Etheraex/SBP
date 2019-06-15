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
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _login.Show();
        }
    }
}
