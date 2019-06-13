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
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using SBP_Data.DTOs;

namespace SBP_Projekat.Forme
{
    public partial class MainForm : Form
    {
        private IgracDTO _igrac;
        private List<LikDTO> _listaLikova;
        public LikDTO Character { get; set; }

        public MainForm()
        {
            this.WindowState = FormWindowState.Maximized;
            var tmp = new WelcomeForm(this).ShowDialog();
            if (tmp == DialogResult.OK)
            {
                InitializeComponent();
            }
            else
                Application.Exit();
        }

        public void SetPlayer(IgracDTO igrac)
        {
            _igrac = igrac;
            this.Show();
        }

        #region Dugmici
        private void cmd_logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion


        #region DropMenu

        private void cmd_fullScreen_Click(object sender, EventArgs e)
        {
            this.WindowState = (this.WindowState ==  FormWindowState.Maximized)?FormWindowState.Normal:FormWindowState.Maximized;
        }

        private void cmd_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mojProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var temp = new ProfileForm(_igrac, this);
            temp.Show();
        }

        private void izborKarakteraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var temp = new CharacterSelectionForm(_igrac, this);
            temp.Show();
        }

        private void alijanseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var temp = new AlianceForm(_igrac, this);
            temp.Show();
        }

        private void kuestoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var temp = new QuestForm(_igrac, this);
            temp.Show();
        }

        private void inventarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var temp = new InventoryForm(_igrac, this);
            temp.Show();
        }
        #endregion


        //private void cmd_zapocni_igru_Click(object sender, EventArgs e)
        //{
        //    int index = lb_likovi.SelectedIndex;
        //    if (_listaLikova == null || index == -1)
        //        MessageBox.Show("Niste izabrali lika");
        //    else
        //    {
        //        //MessageBox.Show("izabrali ste lika: " + _listaLikova[index].ToString());
        //        DTOManager.Instance.zapocniSesiju(_listaLikova[index], _igrac);
        //    }
        //}
    }
}
