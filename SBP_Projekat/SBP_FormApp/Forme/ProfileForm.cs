﻿using SBP_Data.DTOs;
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
        public ProfileForm(IgracDTO igrac,Form parent)
        {
            this.MdiParent = parent;
            InitializeComponent();
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
    }
}