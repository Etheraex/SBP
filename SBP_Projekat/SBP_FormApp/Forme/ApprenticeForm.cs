﻿using SBP_Data;
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
    public partial class ApprenticeForm : Form
    {
        LikDTO _lik;
        SegrtDTO _segrt;
        public ApprenticeForm(LikDTO lik, Form form)
        {
            this.MdiParent = form;
            _lik = lik;
            InitializeComponent();
        }

        private void cmd_odbaci_Click(object sender, EventArgs e)
        {
            if(_segrt != null)
            {
                dgv_my_apprentice.DataSource = null;
                DTOManager.Instance.DeleteEntity(_segrt);
                _segrt = null;
            }
        }

        private void PrikaziSegrta()
        {
            SegrtDTO tmp = null;
            try
            {
                tmp = DTOManager.Instance.GetApprentice(_lik.ID);
            }
            catch(NullReferenceException)
            {
                // Samo ce da ostane prazan data grid view
            }
            _segrt = tmp;
            // Mora u listu zbog dgv
            var list = new List<SegrtDTO>();
            list.Add(tmp);
            dgv_my_apprentice.DataSource = list;
        }

        private void ApprenticeForm_Load(object sender, EventArgs e)
        {
            PrikaziSegrta();
        }

        private void cmd_recruit_Click(object sender, EventArgs e)
        {
            if(_segrt != null)
            {
                MessageBox.Show("Vec imate segrta");
                return;
            }
            var tmp = new RecruitApprenticeForm(MdiParent,_lik);
            tmp.Show();
        }
    }
}
