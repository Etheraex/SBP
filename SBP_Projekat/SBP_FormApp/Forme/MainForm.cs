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
        private SesijaDTO _sesija;
        private LikDTO _character;

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
            this.CloseSession();
            Application.Exit();
        }
        #endregion

        #region AdditionalMethods

        private void cmd_fullScreen_Click(object sender, EventArgs e)
        {
            this.WindowState = (this.WindowState == FormWindowState.Maximized) ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void cmd_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool IsActive(string name)
        {
            bool active = false;
            foreach (Form c in this.MdiChildren)
                if (c.Name == name) 
                    active = true;
            return active;
        }

        #endregion

        #region DropMenu

        private void mojProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!IsActive("ProfileForm"))
            {
                var temp = new ProfileForm(_igrac, this);
                temp.Show();
            }
        }

        private void izborKarakteraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsActive("CharacterSelectionForm"))
            {
                var temp = new CharacterSelectionForm(_igrac, this);
                temp.Show();
            }
        }

        private void alijanseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsActive("AlianceForm"))
            {
                var temp = new AlianceForm(_igrac, this);
                temp.Show();
            }
        }

        private void kuestoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsActive("QuestForm"))
            {
                var temp = new QuestForm(_igrac, this);
                temp.Show();
            }
        }

        private void inventarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsActive("InventoryForm"))
            {
                var temp = new InventoryForm(_igrac, this);
                temp.Show();
            }
        }
        private void segrtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsActive("ApprenticeForm"))
            {
                if (_character == null)
                {
                    MessageBox.Show("Niste izabrali lika");
                    return;
                }
                var temp = new ApprenticeForm(_character, this);
                temp.Show();
            }
        }
        #endregion


        public void startSeasson(LikDTO lik)
        {
            if (lik == null)
                MessageBox.Show("Niste izabrali lika");
            else
            {
                _sesija = DTOManager.Instance.ZapocniSesiju(lik, _igrac);
                _character = lik;
            }
        }
        public void CloseSession()
        {
            if (_sesija != null)
            {
                DTOManager.Instance.CloseSession(_sesija);
            }
        }


    }
}
