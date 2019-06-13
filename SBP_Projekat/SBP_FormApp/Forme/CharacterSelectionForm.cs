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
            listView1.Items.Clear();
            foreach (LikDTO lik in _likovi)
            {
                ListViewItem item = new ListViewItem(new string[] { lik.NormalizedRasa,lik.HP.ToString() , lik.Zlato.ToString() });

                listView1.Items.Add(item);
            }
            listView1.Refresh();

            this.dgv_likovi_dd.DataSource = _likovi;
     
        }

        private void updateTalb() { }
    }
}
