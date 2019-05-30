using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_Data.Models
{
    public class AbstractPredmet
    {
        public virtual int Id { get; set; }
        public virtual int XpBonus { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string Opis { get; set; }
        public virtual string VrstaOruzja { get; set; }
        public virtual Quest Pripada { get; set; }
        public virtual IList<Rasa> MozeDaKoristi {get; set;}
        public virtual IList<Igrac> Igraci { get; set; }

        public AbstractPredmet()
        {
            MozeDaKoristi = new List<Rasa>();
            this.Igraci = new List<Igrac>();
        }
    }

    public class Predmet : AbstractPredmet
    {

    }

    public class Oruzje : AbstractPredmet
    {

    }
}
