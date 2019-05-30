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

        public override string ToString()
        {
            return EntityType.Name + Ime;
        }

        public override object ConvertToEntity()
        {
            var s = new Segrt();
            s.Ime = Ime;
            s.Bonus = Bonus;
            s.Rasa = Rasa;
            s.Lik = Lik;
            return s;
        }

        public SegrtDTO(Segrt s)
        {
            base.EntityType = typeof(Segrt);
            ID = s.Id;
            Ime = s.Ime;
            Bonus = s.Bonus;
            Rasa = s.Rasa;
            Lik = s.Lik;
        }
    }
}
