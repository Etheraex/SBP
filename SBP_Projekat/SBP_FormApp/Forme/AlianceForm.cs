using SBP_Data.DTOs;
using SBP_Data;
using SBP_Data.Models;
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
    public partial class AlianceForm : Form
    {
        IgracDTO _igrac;
        AlijansaDTO cur;
        private List<AlijansaDTO> alijanse = new List<AlijansaDTO>();
        public AlianceForm(IgracDTO igrac,Form parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _igrac = igrac;
            if (igrac.PripadaAlijansi != null)
            {
                btnJoin.Visible = false;
                btnLeave.Visible = true;
            }
            else
            {
                btnJoin.Visible = true;
                btnLeave.Visible = false;
            }
        }

        private void AlianceForm_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }

        private Task LoadInfo()
        {
            return Task.Run(() =>
                    {
                        dgvAlijanse.Invoke((MethodInvoker)(() =>
                        {
                            alijanse = DTOManager.Instance.GetDTOList<AlijansaDTO, Alijansa>();
                            dgvAlijanse.DataSource = alijanse;
                        }));
              
                        lAlijansa.Invoke((MethodInvoker)(() =>
                        {
                            if (_igrac.PripadaAlijansi != null)
                                cur = DTOManager.Instance.GetDTOById<AlijansaDTO>(_igrac.PripadaAlijansi.ID);
                            if (cur != null)
                            {
                                lAlijansa.Text = cur.Naziv;
                                lAlijansa.Visible = true;
                                label1.Invoke((MethodInvoker)(() => { label1.Visible = true; }));
                            }  
                        }));
                    });
        }

        private void cmd_Join_Click(object sender, EventArgs e)
        {
            var newAlijansa=DTOManager.Instance.GetEntityById<AlijansaDTO,Alijansa>(alijanse[dgvAlijanse.CurrentCell.RowIndex].ID);
            _igrac.PripadaAlijansi = newAlijansa;
            DTOManager.Instance.UpdateEntity(_igrac);
            LoadInfo();
            btnJoin.Visible = false;
            btnLeave.Visible = true;
            label1.Visible = true;
            lAlijansa.Visible = true;

        }

        private void cmd_Leave_Click(object sender, EventArgs e)
        {
            _igrac.PripadaAlijansi = null;
            DTOManager.Instance.UpdateEntity(_igrac);
            cur = null;
            LoadInfo();
            btnJoin.Visible = true;
            btnLeave.Visible = false;
            label1.Visible = false;
            lAlijansa.Visible = false;
        }

        private void cmd_create_aliance_Click(object sender, EventArgs e)
        {
            if(cur != null)
            {
                MessageBox.Show("Vec se nalazite u alijansi i nemozete da napravite novu");
                return;
            }
            var tmp = new CreateAlianceForm(MdiParent);
            tmp.Show();
        }

        private void cmd_savezi_Click(object sender, EventArgs e)
        {
            lblSavez.Visible = true;
            richTextBox1.Visible = true;
            richTextBox1.Text = "";
            var tmp = DTOManager.Instance.vratiSaveze(alijanse[dgvAlijanse.CurrentCell.RowIndex].ID);
            foreach (var s in tmp)
                richTextBox1.Text += s + "\n";
        }
    }
}
