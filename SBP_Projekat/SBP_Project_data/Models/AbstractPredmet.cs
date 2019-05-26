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
        public virtual IList<Rasa> MozeDaKoristi {get; set;}
        public virtual IList<Igrac> Igraci { get; set; }

        public AbstractPredmet()
        {
            MozeDaKoristi = new List<Rasa>();
            this.Igraci = new List<Igrac>();
        }
        // Ovo treba da se edituje na EER dijagramu
        public AbstractPredmet(int xp, string naziv, string opis, string vrstaOruzija, Quest quest)
        {
            XpBonus = xp;
            Naziv = naziv;
            Opis = opis;
            VrstaOruzja = vrstaOruzija;
            Pripada = quest;
            MozeDaKoristi = new List<Rasa>();
            this.Igraci = new List<Igrac>();
        }
    }

    public class Predmet : AbstractPredmet
    {
        public Predmet()
        {

        }

        public Predmet(int xp, string naziv, string opis, string vrstaOruzija, Quest quest) : base(xp, naziv, opis, vrstaOruzija, quest) { }
    }

    public class Oruzje : AbstractPredmet
    {
        public Oruzje()
        {

        }

        public Oruzje(int x, string n, string o, string v, Quest p) : base(x, n, o, v, p) { }
    }
}
