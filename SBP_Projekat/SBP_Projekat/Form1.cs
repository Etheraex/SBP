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
                SBP_Project_data.Models.Ork ork = (SBP_Project_data.Models.Ork)rasa;

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
    }
}
