using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_Data.Models
{
    public class Segrt
    {
        public virtual int Id { get; set; }
        public virtual string Ime { get; set; }
        public virtual int Bonus { get; set; }
        public virtual Rasa Rasa { get; set; }
        public virtual Lik Lik { get; set; }
    }
}
