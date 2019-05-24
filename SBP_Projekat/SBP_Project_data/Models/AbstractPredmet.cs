using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_Project_data.Models
{
    public class AbstractPredmet
    {
        public virtual int Id { get; set; }
        public virtual int XpBonus { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string Opis { get; set; }
        public virtual string VrstaOruzja { get; set; }
        public virtual Quest Pripada { get; set; }
        public virtual List<Rasa> MozeDaKoristi {get; set;}

        public AbstractPredmet()
        {
            MozeDaKoristi = new List<Rasa>();
        }
        // Ovo treba da se edituje na EER dijagramu
        public AbstractPredmet(int x, string n, string o, string v, Quest p)
        {
            XpBonus = x;
            Naziv = n;
            Opis = o;
            VrstaOruzja = v;
            Pripada = p;
        }
    }

    public class Predmet : AbstractPredmet
    {
        public Predmet()
        {

        }

        public Predmet(int x, string n, string o, string v, Quest p) : base(x, n, o, v, p) { }
    }

    public class Oruzje : AbstractPredmet
    {
        public Oruzje()
        {

        }

        public Oruzje(int x, string n, string o, string v, Quest p) : base(x, n, o, v, p) { }
    }
}
