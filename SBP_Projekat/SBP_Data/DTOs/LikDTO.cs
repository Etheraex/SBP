using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using SBP_Data.Models;

namespace SBP_Data.DTOs
{
    public class LikDTO : AbstractDTO
    {
        public double Zlato { get; set; }
        public int HP { get; set; }
        public int XP { get; set; }
        public int StepenZamora { get; set; }
        public Rasa Rasa { get; set; }
        public string NormalizedRasa { get { return this.Rasa.GetType().Name; } }
        public Igrac Igrac { get; set; }

        public LikDTO()
        {
            base.EntityType = typeof(Lik);
        }

        public override string ToString()
        {
            return HP.ToString() + " " + XP.ToString() +" "+ StepenZamora.ToString();
        }

        public LikDTO(Lik i)
        {
            if (i != null)
            {
                base.EntityType = typeof(Lik);
                ID = i.Id;
                Zlato = i.Zlato;
                HP = i.HP;
                XP = i.XP;
                StepenZamora = i.StepenZamora;
                Rasa = i.Rasa;
                Igrac = i.Igrac;
            }
            else
                throw new NullReferenceException();
        }

        public override object CreateOrUpdate(object input)
        {
            Lik i = CheckStuff((Lik)input);
            if (ID != 0)
                i.Id = ID;

            i.Zlato = Zlato;
            i.HP = HP;
            i.XP = XP;
            i.StepenZamora = StepenZamora;
            i.Rasa = Rasa;
            i.Igrac = Igrac;

            return i;
        }
    }
}
