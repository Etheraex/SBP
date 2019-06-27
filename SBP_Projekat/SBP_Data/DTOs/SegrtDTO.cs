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
        public Rasa Rasa { get; set; }
        public Lik Lik { get; set; }
        public string NormalizedRasa { get { return this.Rasa.GetType().Name; } }


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
                s.Id = ID;

            s.Ime = Ime;
            s.Bonus = Bonus;

            return s;
        }

        public SegrtDTO(Segrt s)
        {
            if (s != null)
            {
                base.EntityType = typeof(Segrt);
                ID = s.Id;
                Ime = s.Ime;
                Bonus = s.Bonus;
                Rasa = s.Rasa;
                Lik = s.Lik;
            }
            else
                throw new NullReferenceException();
        }
    }
}
