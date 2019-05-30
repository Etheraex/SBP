using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public Igrac Igrac { get; set; }

        public LikDTO()
        {

        }

        public override string ToString()
        {
            return EntityType.Name + HP;
        }

        public LikDTO(Lik i)
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

        public override object CreateOrUpdate(object input)
        {
            Lik i = null;
            if (input != null)
                i = input as Lik;
            else if (i == null || input == null)
                i = new Lik();

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
