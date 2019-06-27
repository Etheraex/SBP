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

        public AlijansaDTO PripadaAlijansi { get; set; }
        public IList<AbstractPredmetDTO> Predmeti { get; set; }
        public IList<string> IspunjeniQuestiov { get; set; }

        public override string ToString()
        {
            return EntityType.Name + Pol;
        }

        public IgracDTO(Igrac i)
        {
            if (i != null)
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
                if(i.PripadaAlijansi!=null)
                PripadaAlijansi = new AlijansaDTO(i.PripadaAlijansi);
                Predmeti = new List<AbstractPredmetDTO>();
                foreach (var a in i.Predmeti)
                {
                    if(a.GetType().Equals(typeof(Oruzje)))
                    {
                        Predmeti.Add(new OruzjeDTO(a as Oruzje));
                    }
                    else
                    {
                        Predmeti.Add(new PredmetDTO(a as Predmet));
                    }
                }
                IspunjeniQuestiov = new List<string>();
                foreach (var a in i.IspunjeniQuestiov)
                {
                    IspunjeniQuestiov.Add(a.Id.ToString());
                }
            }
            else
                throw new NullReferenceException();
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
           
        
            return i;
        }
    }
}
