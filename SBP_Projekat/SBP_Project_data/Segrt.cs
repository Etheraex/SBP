using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_Project_data
{
    public class Segrt
    {
        public virtual int Id { get; set; }
        public virtual string Ime { get; set; }
        public virtual int Bonus { get; set; }
        public virtual Rasa RasaID { get; set; }
        public virtual Lik LikID { get; set; }
    }
}
