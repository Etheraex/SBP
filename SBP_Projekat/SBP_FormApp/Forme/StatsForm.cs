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
    public partial class StatsForm : Form
    {
        private LikDTO _lik;
        public StatsForm(LikDTO lik, Form f)
        {
            InitializeComponent();
            MdiParent = f;
            _lik = lik;
            UpdateForm();
        }

        private void UpdateForm()
        {
            tb_rasa.Text = _lik.NormalizedRasa;
            tb_hp.Text = _lik.HP.ToString();
            tb_xp.Text = _lik.XP.ToString();
            tb_zlato.Text = _lik.Zlato.ToString();
            tb_zamor.Text = _lik.StepenZamora.ToString();
        }
    }
}
