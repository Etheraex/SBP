using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_Project_data
{
    public class Igrac
    {
        public virtual int Id { get; private set; }
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
        public virtual int Uzrast { get; set; }
        public virtual string Nadimak { get; set; }
        public virtual char Pol { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }

        public virtual Alijansa PripadaAlijansi { get; set; }

        public Igrac(string username, string pass, int uzrast, string nick, char p, string ime, string prezime, Alijansa a)
        {
            Username = username;
            Password = pass;
            Uzrast = uzrast;
            Nadimak = nick;
            Pol = p;
            Ime = ime;
            Prezime = prezime;
            PripadaAlijansi = a;
        }
    }
}
