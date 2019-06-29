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
using SBP_Data.DTOs;
using SBP_Data.Models;

namespace SBP_Projekat.Forme
{
    public partial class AddItemForm : Form
    {
        public AddItemForm()
        {
            InitializeComponent();
        }

        private void cmd_create_Click(object sender, EventArgs e)
        {
            if (!ValidateNaziv() || !ValidateRase() || !ValidateTipOruzja() || !ValidateTipPredmeta() || !ValidateOpis())
                return;
            Random rand = new Random();
            var list = new List<RasaDTO>();
            var tmp = cb_rase.CheckedItems;
            if (tmp.Count == 5)
                list = null; // ako je izabrano da sve rase mogu da koriste predmet u bazi se upisuje null
            else
                foreach(var r in tmp)
                {
                    switch (r.ToString())
                    {
                        case "Covek":
                            list.Add(DTOManager.Instance.GetDTOById<CovekDTO>(1));
                            break;
                        case "Patuljak":
                            list.Add(DTOManager.Instance.GetDTOById<PatuljakDTO>(2));
                            break;
                        case "Ork":
                            list.Add(DTOManager.Instance.GetDTOById<OrkDTO>(4));
                            break;
                        case "Vilenjak":
                            list.Add(DTOManager.Instance.GetDTOById<VilenjakDTO>(3));
                            break;
                        case "Demon":
                            list.Add(DTOManager.Instance.GetDTOById<DemonDTO>(5));
                            break;
                    }
                }
            MessageBox.Show(cb_tip_predmeta.SelectedItem.ToString());
            if (cb_tip_predmeta.SelectedItem.ToString() == "Predmet")
            {
                var predmet = new PredmetDTO
                {
                    Naziv = tb_naziv.Text,
                    Opis = rtb_opis.Text,
                    XpBonus = rand.Next(minValue: 1, maxValue: 20),
                    MozeDaKoristi = list,
                    Pripada = null
                };
                DTOManager.Instance.SaveEntity(predmet);
            }
            else if (cb_tip_predmeta.SelectedItem.ToString() == "Oruzje")
            {
                var oruzje = new OruzjeDTO
                {
                    Naziv = tb_naziv.Text,
                    Opis = rtb_opis.Text,
                    XpBonus = rand.Next(minValue: 1, maxValue: 20),
                    MozeDaKoristi = list,
                    VrstaOruzja = tb_tip_oruzja.Text,
                    Pripada = null
                };
                DTOManager.Instance.SaveEntity(oruzje);
            }
            this.Close();
        }

        private void cb_tip_predmeta_Validating(object sender, CancelEventArgs e)
        {
            ValidateTipPredmeta();
        }

        private void tb_naziv_Validating(object sender, CancelEventArgs e)
        {
            ValidateNaziv();
        }

        private void tb_tip_oruzja_Validating(object sender, CancelEventArgs e)
        {
            ValidateTipOruzja();
        }

        private void cb_rase_Validating(object sender, CancelEventArgs e)
        {
            ValidateRase();
        }

        private void rtb_opis_Validating(object sender, CancelEventArgs e)
        {
            ValidateOpis();
        }

        private bool ValidateOpis()
        {
            if (rtb_opis.Text == "")
            {
                error_create_item.SetError(tb_naziv, "Morate uneti opis");
                return false;
            }
            return true;
        }

        private bool ValidateNaziv()
        {
            if (tb_naziv.Text == "")
            {
                error_create_item.SetError(tb_naziv, "Morate uneti tip oruzja");
                return false;
            }
            if (tb_naziv.Text.Any(char.IsDigit))
            {
                error_create_item.SetError(tb_naziv, "Morate tip bez brojeva");
                return false;
            }
            return true;
        }

        private bool ValidateTipOruzja()
        {
            if(tb_tip_oruzja.Text == "")
            {
                error_create_item.SetError(tb_tip_oruzja, "Morate uneti tip oruzja");
                return false;
            }
            if (tb_tip_oruzja.Text.Any(char.IsDigit))
            {
                error_create_item.SetError(tb_tip_oruzja, "Morate tip bez brojeva");
                return false;
            }
            return true;
        }

        private bool ValidateRase()
        {
            if(cb_rase.SelectedIndices.Count == 0)
            {
                error_create_item.SetError(cb_rase, "Morate izabrati rase");
                return false;
            }
            return true;
        }

        private bool ValidateTipPredmeta()
        {
            if(cb_tip_predmeta.SelectedIndex == -1)
            {
                error_create_item.SetError(cb_tip_predmeta, "Morate izabrati tip;");
                return false;
            }
                
            return true;
        }

        
    }
}
