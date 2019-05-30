using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_Data.Models
{
    public class Quest
    {
        public virtual int Id { get; set; }
        public virtual int XpGain { get; set; }
        public virtual IList<Predmet> Predmeti { get; set; }
        public virtual IList<Alijansa> AlijanseKojeSuIspunile { get; set; }
        public virtual IList<Igrac> IgraciKojiSuIspunili { get; set; }

        public Quest()
        {
            Predmeti = new List<Predmet>();
            this.AlijanseKojeSuIspunile = new List<Alijansa>();
            this.IgraciKojiSuIspunili = new List<Igrac>();
        }
    }
}
