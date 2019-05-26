using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBP_Project_data.Models;

namespace SBP_Project_data.Models
{
    public class Igrac
    {
        public virtual int Id { get; set; }
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
        public virtual int Uzrast { get; set; }
        public virtual string Nadimak { get; set; }
        public virtual char Pol { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }

        public virtual Alijansa PripadaAlijansi { get; set; }
        public virtual IList<AbstractPredmet> Predmeti { get; set; }
        public virtual IList<Quest> IspunjeniQuestiov { get; set; }

        public Igrac()
        {
            this.Predmeti = new List<AbstractPredmet>();
            this.IspunjeniQuestiov = new List<Quest>();
        }

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
            this.Predmeti = new List<AbstractPredmet>();
            this.IspunjeniQuestiov = new List<Quest>();
        }
    }
}
