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
        public AlianceForm(IgracDTO igrac,Form parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _igrac = igrac;
           
        }

        private void AlianceForm_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
               
                   
                dgvAlijanse.Invoke((MethodInvoker)(() =>
                {
                    dgvAlijanse.DataSource = DTOManager.Instance.getDTOList<AlijansaDTO, Alijansa>();
                }));
            }
            );

        }

        
    }
}
