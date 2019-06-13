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

            var quests = VratiListuQuestova(_igrac.ID);           
                                                   
                foreach (QuestDTO q in quests)
                {
                textBox1.Text += q.XpGain+"\r\n";
                }

            
        }

        public List<QuestDTO> VratiListuQuestova(int id)
        {
            var Quests = new List<Quest>();

            using (ISession s = DataLayer.Session)
            {
                Quests =s.Query<Quest>().Where(q => (!q.IgraciKojiSuIspunili.Any(x => x.Id == _igrac.ID))).ToList();
            }
            var tmp = new List<QuestDTO>();

            foreach (var quest in Quests)
                tmp.Add(new QuestDTO(quest));

            return tmp;
        }

        private void QuestForm_Load(object sender, EventArgs e)
        {

            var quests = VratiListuQuestova(_igrac.ID);

            foreach (QuestDTO q in quests)
            {
                textBox1.Text += q.XpGain + "\r\n";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
