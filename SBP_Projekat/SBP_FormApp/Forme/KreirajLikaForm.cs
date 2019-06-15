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
using SBP_Data.DTOs;

namespace SBP_Projekat.Forme
{
    public partial class KreirajLikaForm : Form
    {
        private int _id;
        public KreirajLikaForm(int id)
        {
            InitializeComponent();
            var rase = new List<string> { "Covek", "Vilenjak", "Ork", "Demon", "Patuljak" };
            foreach (var r in rase)
                cb_rasa.Items.Add(r);
            _id = id;
        }

        private void cmd_kreiraj_Click(object sender, EventArgs e)
        {
            if (!ValidateHP() || !ValidateRasa() || !ValidateZamor())
                return;
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

            var lik = new LikDTO()
            {
                HP = int.Parse(tb_hp.Text),
                XP = 0,
                StepenZamora = int.Parse(tb_stepen_zamora.Text),
                Igrac = DTOManager.Instance.GetEntityById<IgracDTO, Igrac>(_id),
                Zlato = 0,
                Rasa = tmp
            };
            DTOManager.Instance.SaveEntity(lik);
            this.Close();
        }

        private void cb_rasa_Validating(object sender, CancelEventArgs e)
        {
            ValidateRasa();
        }

        private void tb_hp_Validating(object sender, CancelEventArgs e)
        {
            ValidateHP();
        }

        private void tb_stepen_zamora_Validating(object sender, CancelEventArgs e)
        {
            ValidateZamor();
        }

        private bool ValidateRasa()
        {
            if(cb_rasa.SelectedIndex == -1)
            {
                error_create_character.SetError(cb_rasa, "Morate izabrati rasu");
                return false;
            }
            return true;
        }

        private bool ValidateHP()
        {
            if(tb_hp.Text == "")
            {
                error_create_character.SetError(tb_hp, "Morate uneti hp");
                return false;
            }
            else if(!int.TryParse(tb_hp.Text, out int tmp))
            {
                error_create_character.SetError(tb_hp, "Samo brojke!");
                return false;
            }
            return true;
        }

        private bool ValidateZamor()
        {
            if (tb_stepen_zamora.Text == "")
            {
                error_create_character.SetError(tb_stepen_zamora, "Morate uneti stepen zamora");
                return false;
            }
            else if (!int.TryParse(tb_stepen_zamora.Text, out int tmp))
            {
                error_create_character.SetError(tb_stepen_zamora, "Samo brojke!");
                return false;
            }
            return true;
        }

    }
}
