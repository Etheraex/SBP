using SBP_Data.DTOs;
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

        public GameForm(IgracDTO igrac, Form f)
        {
            InitializeComponent();
            _igrac = igrac;
            MdiParent = f;
            cmd_finish.Visible = false;
            StartQuest();
        }

        public async void StartQuest()
        {
            await DoQuestType1();
            cmd_finish.Visible = true;
        }

        private async Task DoQuestType1()
        {
            await Task.Run(() =>
            {
                for (var i = 0; i < 40; i++)
                {
                    textBox1.Text += "# ";
                    Thread.Sleep(500);
                }
            });
        }

        private void cmd_finish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_giveup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
