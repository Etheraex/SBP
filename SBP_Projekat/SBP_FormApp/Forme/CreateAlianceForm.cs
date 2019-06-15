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
    public partial class CreateAlianceForm : Form
    {
        public CreateAlianceForm(Form f)
        {
            InitializeComponent();
            MdiParent = f;
        }

        private void cmd_create_Click(object sender, EventArgs e)
        {
            if (!ValidateNaziv() || !ValidateMinMax())
                return;
            Random rand = new Random();
            var alijansa = new AlijansaDTO
            {
                MaxBrojIgraca = (int)nud_max.Value,
                MinBrojIgraca = (int)nud_min.Value,
                Naziv = tb_naziv.Text,
                HpBonus = rand.Next(minValue:1,maxValue:20),
                XpBonus = rand.Next(minValue:1,maxValue:15)
            };
            DTOManager.Instance.SaveEntity(alijansa);
            this.Close();
        }

        private void tb_naziv_Validating(object sender, CancelEventArgs e)
        {
            ValidateNaziv();
        }

        private void nud_min_Validating(object sender, CancelEventArgs e)
        {
            ValidateMinMax();
        }

        private void nud_max_Validating(object sender, CancelEventArgs e)
        {
            ValidateMinMax();
        }

        private bool ValidateMinMax()
        {
            if(nud_max.Value < nud_min.Value)
            {
                error_create_aliance.SetError(nud_min, "Vrednost max mora biti veca od vrednosti min");
                return false;
            }
            return true;
        }

        private bool ValidateNaziv()
        {
            if(tb_naziv.Text == "")
            {
                error_create_aliance.SetError(tb_naziv, "Morate uneti naziv alijanse");
                return false;
            }
            else if(tb_naziv.Text.Any(char.IsDigit))
            {
                error_create_aliance.SetError(tb_naziv, "Naziv ne sme imati cifre");
                return false;
            }
            return true;
        }
    }
}
