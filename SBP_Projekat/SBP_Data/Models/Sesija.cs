using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_Data.Models
{
    public class Sesija
    {
        public virtual int Id { get; set; }
        public virtual double Gold { get; set; }
        public virtual int ZaradjeniXP { get; set; }
        public virtual string VremePocetka { get; set; }
        public virtual string VremeKraja { get; set; }

        public virtual Igrac Igrac { get; set; }
        public virtual Lik Lik { get; set; }
    }
}