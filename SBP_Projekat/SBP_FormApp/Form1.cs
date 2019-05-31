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

namespace SBP_Projekat
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.Session;

                var rasa = s.Load<Covek>(1);
                Covek ork = (Covek)rasa;

                MessageBox.Show(ork.UmesnostUSkrivanju.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.Session;

                var Lik = s.Load<SBP_Data.Models.Lik>(5);
                //SBP_Project_data.Models.Ork ork = (SBP_Project_data.Models.Ork)rasa;

                MessageBox.Show("HP lika je: " + Lik.HP +" a id njegove rase je "+  Lik.Rasa.Id);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.Session;

                var Alijansa = s.Load<SBP_Data.Models.Alijansa>(1);
            
                MessageBox.Show(Alijansa.Naziv);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.Session;

                var Igrac = s.Load<SBP_Data.Models.Igrac>(2);

                MessageBox.Show(Igrac.Username);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.Session;

                var predmet = (Oruzje)s.Load<Oruzje>(8);
                

                MessageBox.Show(predmet.Naziv +" "+ predmet.VrstaOruzja);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            try
            {
                ISession s = DataLayer.Session;

                var predmet = (Predmet)s.Load<Predmet>(7);
                String bitan = "bitan za Quest:";
                if (predmet.Pripada != null)
                    bitan += predmet.Pripada.Id;

                MessageBox.Show(predmet.Naziv + " " + predmet.VrstaOruzja + " " +bitan);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.Session;

                Ork bigGreen = s.Load<Ork>(4);
                String koristi = "";
                foreach(AbstractPredmet abstractPredmet in bigGreen.Koristi)
                {
                    koristi += " " + abstractPredmet.Naziv + ",";
                }


                MessageBox.Show("povucena je rasa sa id = "+ bigGreen.Id + " i onda moze da korist sledeca oruzija:" + koristi);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.Session;

                var predmet = s.Load<AbstractPredmet>(3);
                String koristi = "";
                foreach(Rasa rasa in predmet.MozeDaKoristi)
                {
                    koristi += rasa.GetType();
                }

                MessageBox.Show(koristi);


                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.Session;

                var sesija = s.Load<SBP_Data.Models.Sesija>(1);

                MessageBox.Show("loadovana je sesija Igraca " + sesija.Igrac.Ime + "sa likom " + sesija.Lik.Id + " (ovo je id posto nemamo imena za likove)");

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.Session;

                var Alijansa = s.Load<SBP_Data.Models.Alijansa>(1);

                MessageBox.Show("Alijana "+Alijansa.Naziv+"Je u savezu sa alijansom "+Alijansa.Savezi[0].Naziv);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.Session;

                var Igrac = s.Load<SBP_Data.Models.Igrac>(1);

                MessageBox.Show(Igrac.Username +" Poseduje predmet "+ Igrac.Predmeti[0].Naziv );

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.Session;

                var predmet = s.Load<SBP_Data.Models.AbstractPredmet>(1);

                MessageBox.Show(predmet.Naziv+ " Poseduje igrac " + predmet.Igraci[0].Nadimak);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.Session;

                var Alijansa = s.Load<SBP_Data.Models.Alijansa>(1);
                String questovi = "";
                foreach (Quest quest in Alijansa.IspunjeniQuestiovi)
                {
                    questovi += quest.Id + " ";
                }
                MessageBox.Show("Alijana " + Alijansa.Naziv + "Je ispunila kvestove " + questovi +"(ovo su id-jevi posto nemamo imena)");


                var questIzBaze= s.Load<SBP_Data.Models.Quest>(2);
                String alijanse = "";
                foreach (Alijansa alijansa in questIzBaze.AlijanseKojeSuIspunile)
                {
                    alijanse += alijansa.Naziv+ " ";
                }
                MessageBox.Show("Quest sa id: "+ questIzBaze.Id + "je zavrsen od strane ovih alijansa :" + alijanse);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.Session;

                var igrac = s.Load<SBP_Data.Models.Igrac>(1);
                String questovi = "";
                foreach (Quest quest in igrac.IspunjeniQuestiov)
                {
                    questovi += quest.Id + " ";
                }
                MessageBox.Show("Korisnik " + igrac.Nadimak + "Je ispunio kvestove " + questovi + "(ovo su id-jevi posto nemamo imena)");


                var questIzBaze = s.Load<SBP_Data.Models.Quest>(3);
                String igraci = "";
                foreach (Igrac player in questIzBaze.IgraciKojiSuIspunili)
                {
                    igraci += player.Nadimak+ " ";
                }
                MessageBox.Show("Quest sa id: " + questIzBaze.Id + "je zavrsen od strane ovih igraca :" + igraci);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.Session;

                Igrac igrac = session.Load<Igrac>(1);
                Lik lik = session.Load<Lik>(3);

                Sesija sesija = new Sesija();
                sesija.Igrac = igrac;
                sesija.Lik = lik;
                sesija.VremePocetka = DateTime.Now.ToString();
                sesija.VremeKraja = null;
                sesija.ZaradjeniXP = 1911;
                sesija.Gold = 2000;

                session.Save(sesija);

                session.Flush();
                session.Close();
                MessageBox.Show("Uspesno je dodata sesija");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.Session;
                Igrac igrac = new Igrac();
                igrac.Username = "Dandolo II";
                igrac.Password = "burek123";
                igrac.Uzrast = 21;
                igrac.Nadimak = "Ne znam sta je nick";
                igrac.Pol = 'm';
                igrac.Ime = "Dandolo";
                igrac.Prezime = "poslezime";

                Lik lik = new Lik();
                session.Save(igrac);
                session.Flush();
                session.Close();
                MessageBox.Show("Igrac je uspesno sacuvan");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.Session;

                Predmet predmet = new Predmet();
                predmet.XpBonus = 0;
                predmet.Naziv = "Jabuka";
                predmet.Opis = "one apple a day keeps the demons away";

                Ork begGreen = session.Load<Ork>(4);
                predmet.MozeDaKoristi.Add(begGreen);
                session.Save(predmet);
                session.Flush();
                session.Close();
                MessageBox.Show("Dodat je predmet");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.Session;

                Alijansa a = s.Load<Alijansa>(1);

                Quest q = s.Load<Quest>(4);

                AlijansaIspunjava tmp = new AlijansaIspunjava();
                tmp.Alijansa = a;
                tmp.Quest = q;
                tmp.Vreme = 168;

                s.Save(tmp);
                s.Flush();
                MessageBox.Show("Dodata je evidencija o tome da je Alijansa " + a.Naziv + " ispunila quest " + q.Id);

                s.Close();
               
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.Session;

                Igrac igr = s.Load<Igrac>(6);

                Quest q = s.Load<Quest>(2);

                IgracIspunjava tmp = new IgracIspunjava();
                tmp.Igrac = igr;
                tmp.Quest = q;
                tmp.Vreme = 168;

                s.Save(tmp);
                s.Flush();
                MessageBox.Show("Dodata je evidencija o tome da je Igrac " + igr.Nadimak + " ispunio quest " + q.Id);

                s.Close();

                
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.Session;

                Igrac Igrac = s.Load<SBP_Data.Models.Igrac>(11);

                Igrac.Nadimak = "Dandolo the Bastart";
                s.Save(Igrac);
                s.Flush();
                MessageBox.Show("novi nadimak je " + Igrac.Nadimak);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            var lik = DTOManager.Instance.GetEntityById<LikDTO>(11);
            lik.HP = 2;
            DTOManager.Instance.UpdateEntity(lik);
            MessageBox.Show("asd");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            var lik = DTOManager.Instance.GetEntityById<LikDTO>(11);
            var vilenjakDto = DTOManager.Instance.GetEntityById<VilenjakDTO>(3);
            lik.Rasa = (Rasa)vilenjakDto.CreateOrUpdate(null);

            DTOManager.Instance.UpdateEntity(lik);
            MessageBox.Show("Proslo");
        }
    }
}
