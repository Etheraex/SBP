using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_Project_data.Models
{
    public class Rasa
    {
        public Rasa()
        {
        }
        public virtual int Id { get; protected set; }
    }

    public class Covek : Rasa
    {
        public Covek()
        {
        }
        public virtual int UmesnostUSkrivanju { get; set; }

        public Covek(int u)
        {
            UmesnostUSkrivanju = u;
        }
    }

    public abstract class Borac : Rasa
    {
        public Borac()
        {
        }
        public virtual string Specijalizacija { get; set; }

        public Borac(string s)
        {
            Specijalizacija = s;
        }
    }

    public abstract class Mage : Rasa
    {
        public Mage()
        {
        }
        public virtual int NivoEnergije { get; set; }

        public Mage(int n)
        {
            NivoEnergije = n;
        }
    }

    public class Patuljak : Borac
    {
        public Patuljak()
        {
        }
        public Patuljak(string s) : base() { }
    }

    public class Ork : Borac
    {
        public Ork()
        {
        }
        public Ork(string s) : base() { }
    }

    public class Vilenjak : Mage
    {
        public Vilenjak()
        {
        }
        public Vilenjak(int n) : base() { }
    }

    public class Demon : Mage
    {
        public Demon()
        {
        }
        public Demon(int n) : base() { }
    }
}
