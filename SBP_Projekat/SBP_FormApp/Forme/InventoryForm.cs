using System;
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
    public partial class InventoryForm : Form
    {
        private IgracDTO _igrac { get; set; }
        private List<AbstractPredmetDTO> _predmeti;
        public InventoryForm(IgracDTO q, Form parent)
        {
            this.MdiParent = parent;
            _igrac = q;
            InitializeComponent();
        }

        public void LoadData()
        {
            var tmp = DTOManager.Instance.VratiListuPredmeta(_igrac.ID);
            _predmeti = tmp;
            dgv_items.DataSource = tmp;
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cmd_izbaci_Click(object sender, EventArgs e)
        {
            int ind = dgv_items.CurrentCell.RowIndex;

            DTOManager.Instance.RemoveItemFromPlayer(_predmeti[ind].ID, _igrac.ID);
            LoadData();
        }
    }
}
