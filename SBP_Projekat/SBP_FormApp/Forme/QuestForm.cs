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
    public partial class QuestForm : Form
    {
        private IgracDTO _igrac { get; set; }
        public QuestForm(IgracDTO q, Form parent)
        {
            this.MdiParent = parent;
            _igrac = q;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.Session;

                IEnumerable<Quest> quests = s.Query<Quest>()
                                                    .Where(q => (!q.IgraciKojiSuIspunili.Any(x => x.Id == _igrac.ID)));
                                                   
                   foreach (Quest q in quests)
                {
                    MessageBox.Show(q.XpGain.ToString());
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        


        private void QuestForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
