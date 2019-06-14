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
    public partial class ApprenticeForm : Form
    {
        IgracDTO _igrac;
        public ApprenticeForm(IgracDTO igrac, Form form)
        {
            this.MdiParent = form;
            _igrac = igrac;
            InitializeComponent();
        }

        private void cmd_odbaci_Click(object sender, EventArgs e)
        {

        }

        private void cmd_uzmi_novog_Click(object sender, EventArgs e)
        {

        }

        private void ApprenticeForm_Load(object sender, EventArgs e)
        {
            //var tmp = DTOManager.Instance.GetFreeApprentices();
            //dgv
        }
    }
}
