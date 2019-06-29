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
        public RasaDTO Rasa { get; set; }
        public string NormalizedRasa { get { return this.Rasa.GetType().Name; } }
        public IgracDTO Igrac { get; set; }

        public int LocalanStepenZamora { get; set; } // ovo sluzi da za vreme igre proveravam koliko je stamine ostalo liku i da li moze da radi quest

        public LikDTO()
        {
            base.EntityType = typeof(Lik);
        }

        public override string ToString()
        {
            return HP.ToString() + " " + XP.ToString() +" "+ StepenZamora.ToString();
        }

        public LikDTO(Lik i, bool include = true)
        {
            if (i != null)
            {
                base.EntityType = typeof(Lik);
                ID = i.Id;
                Zlato = i.Zlato;
                HP = i.HP;
                XP = i.XP;
                LocalanStepenZamora = StepenZamora = i.StepenZamora;

                if(i.Igrac !=null && include)
                {
                    this.Igrac = new IgracDTO(i.Igrac, false);
                }
                if(i.Rasa != null && include)
                {
                    String typeInStringForm = i.Rasa.ToString().Replace("Models", "DTOs") + "DTO";
                    this.Rasa = (RasaDTO)Activator.CreateInstance(Type.GetType(typeInStringForm),DTOManager.Instance.UnProxyObjectAs<Rasa>(i.Rasa),false);
                }
            }
            else
                throw new NullReferenceException();
        }

        public override object CreateOrUpdate(object input)
        {
            Lik i = CheckStuff((Lik)input);
            if (ID != 0)
            {
                i.Id = ID;
                Lik old = DTOManager.Instance.GetEntityById<LikDTO, Lik>(ID);
                i.Rasa = old.Rasa;
                i.Igrac = old.Igrac;
            }

            i.Zlato = Zlato;
            i.HP = HP;
            i.XP = XP;
            i.StepenZamora = StepenZamora;
            i.Rasa = (Rasa)Rasa.CreateOrUpdate(i.Rasa);
            i.Igrac = (Igrac)Igrac.CreateOrUpdate(i.Igrac);

            return i;
        }
    }
}
