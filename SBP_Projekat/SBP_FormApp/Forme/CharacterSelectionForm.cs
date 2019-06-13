using System;
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
        public CharacterSelectionForm(IgracDTO igrac , Form parent)
        {
            InitializeComponent();
            this.MdiParent = parent;    
            _igrac = igrac;
            _likovi = DTOManager.Instance.VratiListuLikova(igrac.ID);
            this.dgv_likovi_dd.DataSource = _likovi;    
        }

        private void updateTalb() { }

        private void cmd_napravi_Click(object sender, EventArgs e)
        {
            //new KreirajLikaForm(_igrac.ID, this).ShowDialog();
            //    cmd_prikazi_likove_Click(null, null);
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
                ((MainForm)this.MdiParent).Character = _likovi[index];
                this.Close();
            }
        }
    }
}
