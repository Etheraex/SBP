using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_Project_data.Models
{
    public class Quest
    {   
        public Quest()
        {
            Predmeti = new List<Predmet>();
            this.AlijanseKojeSuIspunile = new List<Alijansa>();
            this.IgraciKojiSuIspunili = new List<Igrac>();
        }

        public virtual int Id { get; set; }
        public virtual int XpGain { get; set; }
        public virtual IList<Predmet> Predmeti { get; set; }
        public virtual IList<Alijansa>  AlijanseKojeSuIspunile{ get; set; } //ako imate bolji predlog ubacite ga samo
        public virtual IList<Igrac> IgraciKojiSuIspunili { get; set; } //ako imate bolji predlog ubacite ga samo
        public Quest(int x)
        {
            XpGain = x;
            this.Predmeti = new List<Predmet>();
            this.AlijanseKojeSuIspunile = new List<Alijansa>();
            this.IgraciKojiSuIspunili = new List<Igrac>();
        }
    }
}
