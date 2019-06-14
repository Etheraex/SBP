using SBP_Data;
using SBP_Data.DTOs;
using SBP_Data.Models;
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
    public partial class RecruitApprenticeForm : Form
    {
        LikDTO _lik;
        public RecruitApprenticeForm(Form f, LikDTO lik)
        {
            InitializeComponent();
            MdiParent = f;
            _lik = lik;
        }

        private void cmd_recruit_Click(object sender, EventArgs e)
        {
            var name = tb_ime.Text;
            Rasa tmp = null;
            switch (cb_rasa.SelectedItem.ToString())
            {
                case "Covek":
                    tmp = DTOManager.Instance.GetEntityById<CovekDTO, Covek>(1);
                    break;
                case "Patuljak":
                    tmp = DTOManager.Instance.GetEntityById<PatuljakDTO, Patuljak>(2);
                    break;
                case "Ork":
                    tmp = DTOManager.Instance.GetEntityById<OrkDTO, Ork>(4);
                    break;
                case "Vilenjak":
                    tmp = DTOManager.Instance.GetEntityById<VilenjakDTO, Vilenjak>(3);
                    break;
                case "Demon":
                    tmp = DTOManager.Instance.GetEntityById<DemonDTO, Demon>(5);
                    break;
            }
            Random rand = new Random();
            var segrt = new SegrtDTO
            {
                Ime = name,
                Rasa = tmp,
                Lik = DTOManager.Instance.GetEntityById<LikDTO,Lik>(_lik.ID),
                Bonus = rand.Next(minValue:10,maxValue:20)
            };
            DTOManager.Instance.SaveEntity(segrt);
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
