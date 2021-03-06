﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SBP_Data.DTOs;
using SBP_Data;
using SBP_Data.Models;
namespace SBP_Projekat.Forme
{
    public partial class CharacterSelectionForm : Form
    {
        IgracDTO _igrac;
        List<LikDTO> _likovi;
        MainForm _parent;
        public CharacterSelectionForm(IgracDTO igrac , Form parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _parent = (MainForm)parent;
            _igrac = igrac;

        }

        private void cmd_napravi_Click(object sender, EventArgs e)
        {
            new KreirajLikaForm(_igrac.ID).ShowDialog();
            UpdateList();
        }

        private void UpdateList()
        {
            _likovi = DTOManager.Instance.VratiListuLikova(_igrac.ID);
            this.dgv_likovi_dd.DataSource = _likovi;
        }

        private void cmd_select_Click(object sender, EventArgs e)
        {
            int index = dgv_likovi_dd.CurrentCell.RowIndex;
            if (index == -1)
            {
                MessageBox.Show("Niste izabrali lika");
            }
            else
            {
                _parent.CloseSession();
                _parent.startSeasson(_likovi[index]);
                this.Close();
            }
        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {
            int index = dgv_likovi_dd.CurrentCell.RowIndex;
            if (index == -1)
            {
                MessageBox.Show("Niste izabrali lika");
            }
            else
            {
                DTOManager.Instance.DeleteEntity(_likovi[index]);
                this.UpdateList();
            }
        }

        private void CharacterSelectionForm_Load(object sender, EventArgs e)
        {
            this.UpdateList();
        }
    }
}
