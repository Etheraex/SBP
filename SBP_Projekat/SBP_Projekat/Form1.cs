using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SBP_Project_data;
using SBP_Project_data.Models;
using SBP_Project_data.Models.KompozitniKljucevi;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;

namespace SBP_Projekat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                var rasa = s.Load<SBP_Project_data.Models.Ork>(4);
                SBP_Project_data.Models.Ork ork = (Ork)rasa;

                MessageBox.Show(ork.Specijalizacija);

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
                ISession s = DataLayer.GetSession();

                var Lik = s.Load<SBP_Project_data.Models.Lik>(5);
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
                ISession s = DataLayer.GetSession();

                var Alijansa = s.Load<SBP_Project_data.Models.Alijansa>(1);
            
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
                ISession s = DataLayer.GetSession();

                var Igrac = s.Load<SBP_Project_data.Models.Igrac>(1);

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
                ISession s = DataLayer.GetSession();

                var predmet = (Oruzje)s.Load<Oruzje>(8);
                

                MessageBox.Show(predmet.Naziv +" "+ predmet.VrstaOruzja);

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
                ISession s = DataLayer.GetSession();

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
                ISession s = DataLayer.GetSession();

                var predmet = s.Load<Oruzje>(8);
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
            Igrac igrac = new Igrac();
            igrac.Id = 6;
            Lik lik = new Lik();
            lik.Id = 8;
            SesijaID sesijaID = new SesijaID();
            sesijaID.Lik = lik;
            sesijaID.Igrac = igrac;
            try
            {
                ISession s = DataLayer.GetSession();

                // var sesija = s.Load<Sesija>(sesijaID);
                /*String koristi = "";
                foreach (Rasa rasa in predmet.MozeDaKoristi)
                {
                    koristi += rasa.GetType();
                }*/

                var sesija = s.Query<Sesija>() //ovo mora zbog lazy Loading
                    .Fetch(x => x.Id)
                    .Where(x => x.Id == sesijaID)
                    .ToList(); //i ovo ne znam dal mora da vracam listu ovo je test samo da vidim dal vraca uopste nesto, verovatno ima pametniji nacin da se ovo radi

                MessageBox.Show("loadovana je sesija Igraca "+ sesija[0].Id.Igrac.Ime +"sa likom " + sesija[0].Id.Lik.Id+" (ovo je id posto nemamo imena za likove)" );


                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }


        }
    }
}
