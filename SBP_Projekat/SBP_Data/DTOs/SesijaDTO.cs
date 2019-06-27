using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBP_Data.Models;


namespace SBP_Data.DTOs
{
    public class SesijaDTO : AbstractDTO
    {
        public double Gold { get; set; }
        public int ZaradjeniXP { get; set; }
        public string VremePocetka { get; set; }
        public string VremeKraja { get; set; }

        public Igrac Igrac { get; set; }
        public Lik Lik { get; set; }

        public string IgracNaziv
        {
            get
            {
                return Igrac.Nadimak;
            }
        }

        public string LikRasa
        {
            get
            {
                return Lik.Rasa.GetType().Name;
            }
        }

        public SesijaDTO()
        {
            EntityType = typeof(Sesija);
        }

        public override string ToString()
        {
            return EntityType.Name + ZaradjeniXP;
        }

        public override object CreateOrUpdate(object input)
        {
            Sesija s = CheckStuff((Sesija)input);
            if (ID != 0)
                s.Id = ID;

            s.Gold = Gold;
            s.ZaradjeniXP = ZaradjeniXP;
            s.VremeKraja = VremeKraja;
            s.VremePocetka = VremePocetka;
            s.Igrac = Igrac;
            s.Lik = Lik;
            return s;
        }

        public SesijaDTO(Sesija s)
        {
            if (s != null)
            {
                base.EntityType = typeof(Sesija);
                ID = s.Id;
                Gold = s.Gold;
                Igrac = s.Igrac;
                Lik = s.Lik;
                ZaradjeniXP = s.ZaradjeniXP;
                VremePocetka = s.VremePocetka;
                VremeKraja = s.VremeKraja;
            }
            else
                throw new NullReferenceException();
        }
    }
}
