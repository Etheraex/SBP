using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBP_Data.Models;

namespace SBP_Data.DTOs
{
    public class IgracDTO : AbstractDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Uzrast { get; set; }
        public string Nadimak { get; set; }
        public char Pol { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public IgracDTO()
        {
            base.EntityType = typeof(Igrac);
        }

        public Alijansa PripadaAlijansi { get; set; }
        public IList<AbstractPredmet> Predmeti { get; set; }
        public IList<Quest> IspunjeniQuestiov { get; set; }

        public override string ToString()
        {
            return EntityType.Name + Pol;
        }

        public IgracDTO(Igrac i)
        {
            base.EntityType = typeof(Igrac);
            ID = i.Id;
            Username = i.Username;
            Password = i.Password;
            Uzrast = i.Uzrast;
            Nadimak = i.Nadimak;
            Pol = i.Pol;
            Ime = i.Ime;
            Prezime = i.Prezime;
            PripadaAlijansi = i.PripadaAlijansi;
            Predmeti = i.Predmeti;
            IspunjeniQuestiov = i.IspunjeniQuestiov;
        }

        public override object CreateOrUpdate(object input )
        {
            Igrac i = CheckStuff((Igrac)input);
            if (ID != 0)
                i.Id = ID;

            i.Username = Username;
            i.Password = Password;
            i.Uzrast = Uzrast;
            i.Nadimak = Nadimak;
            i.Pol = Pol;
            i.Ime = Ime;
            i.Prezime = Prezime;
            i.PripadaAlijansi = PripadaAlijansi;
            i.Predmeti = Predmeti;
            i.IspunjeniQuestiov = IspunjeniQuestiov;
            return i;
        }
    }
}
