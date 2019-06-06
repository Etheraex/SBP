﻿using System;
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

namespace SBP_Projekat
{
    public partial class Form1 : Form
    {
        private IgracDTO _igrac;
        private bool _mouseDown;
        private Point _lastLocation;

        public Form1()
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

        private void cmd_logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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

        private void cmd_prikazi_likove_Click(object sender, EventArgs e)
        {
            var listaLikova = DTOManager.Instance.VratiListuLikova(_igrac.ID);
            var i = 0;
            foreach(var lik in listaLikova)
            {
                rtb_likovi.AppendText(i.ToString() + ")  " +lik.ToString()+"\n");
                i++;
            }
        }

        private void cmd_profile_Click(object sender, EventArgs e)
        {
            new ProfileForm(_igrac).ShowDialog();
        }
    }
}
