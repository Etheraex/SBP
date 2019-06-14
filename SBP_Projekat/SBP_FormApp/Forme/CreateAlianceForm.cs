using SBP_Data;
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
        }
    }
}
