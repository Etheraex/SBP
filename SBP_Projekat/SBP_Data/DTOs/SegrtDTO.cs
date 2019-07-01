using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBP_Data.Models;

namespace SBP_Data.DTOs
{
    public class SegrtDTO : AbstractDTO
    {
        public string Ime { get; set; }
        public int Bonus { get; set; }
        public RasaDTO Rasa { get; set; }
        public LikDTO Lik { get; set; }
        public string NormalizedRasa { get { return (this.Rasa != null) ? this.Rasa.GetType().Name : ""; } }


        public SegrtDTO()
        {
            base.EntityType = typeof(Segrt);
        }

        public override string ToString()
        {
            return EntityType.Name + Ime;
        }

        public override object CreateOrUpdate(object input)
        {
            Segrt s = CheckStuff((Segrt)input);
            if (ID != 0)
            {
                s.Id = ID;
                Segrt old = DTOManager.Instance.GetEntityById<SegrtDTO, Segrt>(ID);
                s.Rasa = old.Rasa;
                s.Lik = old.Lik;
            }

            s.Ime = Ime;
            s.Bonus = Bonus;
            s.Lik = DTOManager.Instance.GetEntityById<LikDTO, Lik>(Lik.ID);

            s.Rasa = (Rasa)DTOManager.Instance.getRasaByID(Rasa.ID).CreateOrUpdate();//DTOManager.Instance.GetEntityById<RasaDTO, Rasa>(Rasa.ID);
            return s;
        }

        public SegrtDTO(Segrt s, bool include = true)
        {
            if (s != null)
            {
                base.EntityType = typeof(Segrt);
                ID = s.Id;
                Ime = s.Ime;
                Bonus = s.Bonus;
                if (s.Lik != null && include)
                    this.Lik = new LikDTO(s.Lik, false);
                if (s.Rasa != null && include)
                {
                    String typeInStringForm = s.Rasa.ToString().Replace("Models", "DTOs") + "DTO";
                    this.Rasa = (RasaDTO)Activator.CreateInstance(Type.GetType(typeInStringForm), DTOManager.Instance.UnProxyObjectAs<Rasa>(s.Rasa), false);
                }
            }
            else
                throw new NullReferenceException();
        }
    }
}
