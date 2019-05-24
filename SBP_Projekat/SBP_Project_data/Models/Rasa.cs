using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_Project_data.Models
{
    public class Rasa
    {
        public virtual int Id { get; private set; }
    }

    public class Covek : Rasa
    {
        public virtual int UmesnostUSkrivanju { get; set; }

        public Covek(int u)
        {
            UmesnostUSkrivanju = u;
        }
    }

    public class Borac : Rasa
    {
        public virtual string Specijalizacija { get; set; }

        public Borac(string s)
        {
            Specijalizacija = s;
        }
    }

    public class Mage : Rasa
    {
        public virtual int NivoEnergije { get; set; }

        public Mage(int n)
        {
            NivoEnergije = n;
        }
    }

    public class Patuljak : Borac
    {
        public Patuljak(string s) : base(s) { }
    }

    public class Ork : Borac
    {
        public Ork(string s) : base(s) { }
    }

    public class Vilenjak : Mage
    {
        public Vilenjak(int n) : base(n) { }
    }

    public class Demon : Mage
    {
        public Demon(int n) : base(n) { }
    }
}
