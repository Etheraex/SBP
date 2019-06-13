﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using SBP_Data;
using SBP_Data.DTOs;
using SBP_Data.Mappings;
using SBP_Data.Models;

namespace SBP_Projekat.Forme
{
    public partial class QuestForm : Form
    {
        private IgracDTO _igrac { get; set; }
        public QuestForm(IgracDTO q, Form parent)
        {
            this.MdiParent = parent;
            _igrac = q;
            InitializeComponent();
        }

        private void QuestForm_Load(object sender, EventArgs e)
        {
            dgv_quest.DataSource = DTOManager.Instance.VratiListuQuestova();
        }

        private void cmd_questItems_Click(object sender, EventArgs e)
        {
            string display = "";
            int ind = dgv_quest.CurrentCell.RowIndex;
            var tmp = new List<AbstractPredmetDTO>();

            if (ind != -1)
                tmp = DTOManager.Instance.VratiListuPredmetaZaKvest(ind + 1);
            else
                MessageBox.Show("Niste izabrali kvest");

            foreach (var p in tmp)
                display += p.Naziv + "\n";
            if (display != "")
                MessageBox.Show(display);
            else
                MessageBox.Show("Za izabrani kvest nisu potrebni predmeti");
        }

        private void cmd_odradi_quest_Click(object sender, EventArgs e)
        {
            int ind = dgv_quest.CurrentCell.RowIndex;

            if (ind != -1)
            {
                var temp = new GameForm(_igrac, this.MdiParent);
                temp.Show();
            }
        }
    }
}
