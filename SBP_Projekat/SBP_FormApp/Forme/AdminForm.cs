using SBP_Data;
using SBP_Data.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBP_Projekat.Forme
{
    public partial class AdminForm : Form
    {
        private List<IgracDTO> _igraci;
        private List<QuestDTO> _questovi;
        private int _page = 0;
        private Form _login;
        public AdminForm(Form l)
        {
            InitializeComponent();
            _login = l;
            dgv_predmeti.Visible = false;
            dgv_sesije.Visible = false;
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _login.Show();
        }

        private void raseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var temp = new RaseForm();
            temp.Show();
        }

        private void predmetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_predmeti.Visible = true;
            var tmp = DTOManager.Instance.GetAllItems();
            dgv_predmeti.DataSource = tmp;
            hideAll();
            dgv_predmeti.Show();
            button4.Visible = true;
        }
        private void LoadSessionData()
        {
            var tmp = DTOManager.Instance.GetSessions(_page);
            dgv_sesije.DataSource = tmp;
        }
        private void sesijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_sesije.Visible = true;
            dgv_sesije.BringToFront();
            hideAll();
            dgv_sesije.Show();
            LoadSessionData();
            button3.Visible = true;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            CurrentPlayersAsync();
            hideAll();
        }
        private async Task CurrentPlayersAsync()
        {
            label2.Text =  (await DTOManager.Instance.GetCurrentSessions()).ToString();
        }
        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            await CurrentPlayersAsync();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _page++;
            if (_page > 0)
            {
                button2.Visible = true;
            }
            LoadSessionData();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (_page > 0)
                _page--;
            if (_page == 0)
                button2.Visible = false;
            LoadSessionData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var temp = new AddItemForm();
            temp.Show();
        }

        private void igraciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _igraci = DTOManager.Instance.vratiSveIgrace();
            dgv_igraci.DataSource = _igraci;
            hideAll();
            dgv_igraci.Show();
        }

        private void hideAll()
        {
            var controls =  this.Controls.OfType<DataGridView>();
            foreach (var item in controls)
            {
                item.Hide();
            }
            button2.Visible = button3.Visible=button4.Visible = false;
        }

        private void cmd_deleteUser_Click(object sender, EventArgs e)
        {
            int index = dgv_igraci.CurrentCell.RowIndex;
            if(index >= 0)
            {
                DTOManager.Instance.DeleteEntity<IgracDTO>(_igraci[index]);
                igraciToolStripMenuItem_Click(null, null);
            }
            else
            {
                MessageBox.Show("niste izabrali korisnika");
            }
        }

        private void dgv_igraci_VisibleChanged(object sender, EventArgs e)
        {
            cmd_deleteUser.Visible = dgv_igraci.Visible;
        }

        private void questoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideAll();
            _questovi = DTOManager.Instance.VratiListuQuestova();
            dgv_quest.DataSource = _questovi;
            dgv_quest.Show();
        }
    }
}
