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
        public AlianceForm(IgracDTO igrac,Form parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _igrac = igrac;

            
        }

        private void AlianceForm_Load(object sender, EventArgs e)
        {
            load();

        }
        private Task load()
        {
            return
            Task.Run(() =>
            {


                dgvAlijanse.Invoke((MethodInvoker)(() =>
                {
                    dgvAlijanse.DataSource = DTOManager.Instance.getDTOList<AlijansaDTO, Alijansa>();
                }));
              
                    lAlijansa.Invoke((MethodInvoker)(() =>
                    {
                        if (_igrac.PripadaAlijansi != null)
                            cur = DTOManager.Instance.GetDTOById<AlijansaDTO>(_igrac.PripadaAlijansi.Id);
                        if (cur != null)
                        {
                            lAlijansa.Text = cur.Naziv;
                            lAlijansa.Visible = true;
                            label1.Invoke((MethodInvoker)(() =>
                            {
                                label1.Visible = true;

                            }));
                        }
                            
                    }));
                
                

            }
            );
        }
        private void btnJoin_Click(object sender, EventArgs e)
        {
            var newAlijansa=DTOManager.Instance.GetEntityById<AlijansaDTO,Alijansa>( dgvAlijanse.CurrentCell.RowIndex+1);
            _igrac.PripadaAlijansi = newAlijansa;
            DTOManager.Instance.UpdateEntity(_igrac);
            load();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            _igrac.PripadaAlijansi = null;
            DTOManager.Instance.UpdateEntity(_igrac);
            load();
        }
    }
}
