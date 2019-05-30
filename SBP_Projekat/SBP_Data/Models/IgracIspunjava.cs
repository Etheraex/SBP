using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_Data.Models
{
    public class IgracIspunjava
    {
        public virtual int Id { get; set; }
        public virtual int Vreme { get; set; }
        public virtual Igrac Igrac{ get; set; }
        public virtual Quest Quest { get; set; }
    }
}
