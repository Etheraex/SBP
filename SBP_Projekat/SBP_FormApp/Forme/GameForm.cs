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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBP_Projekat.Forme
{
    public partial class GameForm : Form
    {
        private IgracDTO _igrac;
        private List<int> _brojevi;
        private int _dobijeniZadatak;
        private int _questID;

        public GameForm(IgracDTO igrac, Form f, int questID)
        {
            InitializeComponent();
            _igrac = igrac;
            textBox1.Visible = false;
            MdiParent = f;
            cmd_finish.Visible = false;
            _questID = questID;
            Random random = new Random();
            var tmp = random.Next(minValue:1,maxValue:3);
            if (tmp == 1)
                StartQuest1();
            else
                StartQuest2();
        }

        public async void StartQuest1()
        {
            textBox1.Visible = true;
            _dobijeniZadatak = 1;
            btn_reset.Visible = false;
            btn_1.Visible = false;
            btn_2.Visible = false;
            btn_3.Visible = false;
            btn_4.Visible = false;
            btn_5.Visible = false;
            label1.Text = "Status izvrsenja kvesta";
            await DoQuest();

            cmd_finish.Visible = true;
        }

        private async Task DoQuest()
        {
            // Loading bar
            textBox1.Visible = true;
            await Task.Run(() =>
            {
                for (var i = 0; i < 40; i++)
                {
                    try
                    {
                        label1.Invoke((MethodInvoker)(() => { textBox1.Text += "# "; }));
                    }
                    catch(InvalidOperationException)  
                    {
                        // Ukoliko se ugasi forma i izgubi se textBox1 baca ovaj exception ali nije bitno
                        // Aplikacija nastavlja sa radom bez obzira na to
                    }
                    Thread.Sleep(500);
                }
            });
        }

        public void StartQuest2()
        {
            btn_reset.Visible = true;
            _dobijeniZadatak = 2;
            textBox1.Visible = false;
            _brojevi = new List<int>(5);
            btn_1.Visible = true;
            btn_2.Visible = true;
            btn_3.Visible = true;
            btn_4.Visible = true;
            btn_5.Visible = true;

            cmd_finish.Visible = true;
        }

        private void cmd_finish_Click(object sender, EventArgs e)
        {
            int i = 0;
            // Za drugi zadatak mora provera da li je lepo odradjen
            if (_dobijeniZadatak == 2)
            {
                var correct = new List<int> { 1, 2, 3, 4, 5 };
                while (i < 5 && _brojevi[i] == correct[i])
                    i++;
                if (i != 5)
                {
                    MessageBox.Show("Netacno ste uradili");
                    this.Close();
                }
            }
            // Za prvi zadatak dugme se pojavi tek kad se napuni progress bar tako da uvek je uspesno zavrsen quest kada se klikne ovo dugme
            MessageBox.Show("Tacno ste uradili");
            var tmp = DTOManager.Instance.GetEntityById<QuestDTO, Quest>(_questID);
            _igrac.IspunjeniQuestiov.Add(tmp);
            DTOManager.Instance.UpdateEntity(_igrac);

            this.Close();
        }

        private void cmd_giveup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            _brojevi.Add(1);
            label1.Text += 1;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            _brojevi.Add(3);
            label1.Text += 3;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            _brojevi.Add(4);
            label1.Text += 4;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            _brojevi.Add(5);
            label1.Text += 5;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            _brojevi.Add(2);
            label1.Text += 2;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            _brojevi = new List<int>(5);
            label1.Text = "";
        }
    }
}
