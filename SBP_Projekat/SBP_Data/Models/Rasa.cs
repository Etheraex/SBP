using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_Data.Models
{
    public class Rasa
    {
        public virtual int Id { get; protected set; }
        public virtual IList<AbstractPredmet> Koristi { get; set; }

        public Rasa()
        {
            Koristi = new List<AbstractPredmet>();
        }
    }

    public class Covek : Rasa
    {
        public virtual int UmesnostUSkrivanju { get; set; }
    }

    public abstract class Borac : Rasa
    {
        public virtual string Specijalizacija { get; set; }
    }

    public abstract class Mage : Rasa
    {
        public virtual int NivoEnergije { get; set; }
    }

    public class Patuljak : Borac
    {

    }

    public class Ork : Borac
    {

    }

    public class Vilenjak : Mage
    {

    }

    public class Demon : Mage
    {

    }
}
