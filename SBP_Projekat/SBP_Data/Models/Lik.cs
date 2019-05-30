using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_Data.Models
{
    public class Lik
    {
        public virtual int Id { get; set; }
        public virtual double Zlato { get; set; }
        public virtual int HP { get; set; }
        public virtual int XP { get; set; }
        public virtual int StepenZamora { get; set; }
        public virtual Rasa Rasa { get; set; }
        public virtual Igrac Igrac { get; set; }
    }
}
