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
        public InventoryForm(IgracDTO q, Form parent)
        {
            this.MdiParent = parent;
            _igrac = q;
            InitializeComponent();
        }

        public List<AbstractPredmetDTO> VratiListuPredmeta(int id)
        {
            var predmeti = new List<AbstractPredmet>();

            using (ISession s = DataLayer.Session)
            {
                predmeti = s.Query<AbstractPredmet>().Where( x=> x.Igraci.Any(y => y.Id == id)).ToList();
            }
            var tmp = new List<AbstractPredmetDTO>();

            foreach (var p in predmeti)
            {
                if(p.GetType() == typeof(Predmet))
                {
                    tmp.Add(new PredmetDTO(p as Predmet));

                }
                else
                    tmp.Add(new OruzjeDTO(p as Oruzje));
            }
                

            return tmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //var tmp = VratiListuPredmeta(1);

           // foreach (var p in tmp)
           // {
           //     richTextBox1.AppendText(p.Naziv + "\n");
           // }
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            var tmp = VratiListuPredmeta(_igrac.ID);
            foreach (var p in tmp)
            {
                richTextBox1.AppendText(p.Naziv + "\n");
            }
        }
    }
}
