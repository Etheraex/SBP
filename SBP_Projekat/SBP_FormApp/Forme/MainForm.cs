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
        private bool _mouseDown;
        private List<LikDTO> _listaLikova;
        private Point _lastLocation;

        public MainForm()
        {
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

        //private void cmd_prikazi_likove_Click(object sender, EventArgs e)
        //{
        //    lb_likovi.Items.Clear();
        //    rtb_likovi.Clear();
        //    var listaLikova = DTOManager.Instance.VratiListuLikova(_igrac.ID);
        //    this._listaLikova = listaLikova;
        //    var i = 0;
        //    foreach(var lik in listaLikova)
        //    {
        //        rtb_likovi.AppendText(i.ToString() + ")  " +lik.ToString()+"\n");
        //        lb_likovi.Items.Add(i.ToString() + ")  " + lik.ToString());
        //        i++;
        //    }
        //}

        private void cmd_profile_Click(object sender, EventArgs e)
        {
            new ProfileForm(_igrac).ShowDialog();
        }

        //private void cmd_napravi_lika_Click(object sender, EventArgs e)
        //{
        //    new KreirajLikaForm(_igrac.ID,this).ShowDialog();
        //    cmd_prikazi_likove_Click(null, null);
        //}
        #endregion


        #region DodatneMetode
        //public void UpdateLikove(LikDTO lik)
        //{
        //    rtb_likovi.AppendText(lik.ToString()+"\n");
        //}

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - _lastLocation.X) + e.X, (this.Location.Y - _lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }

        private void cmd_fullScreen_Click(object sender, EventArgs e)
        {
            this.WindowState = (this.WindowState ==  FormWindowState.Maximized)?FormWindowState.Normal:FormWindowState.Maximized;
        }

        private void cmd_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
