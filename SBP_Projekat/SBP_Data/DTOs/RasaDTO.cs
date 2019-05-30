using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBP_Data.Models;

namespace SBP_Data.DTOs
{
    public abstract class RasaDTO : AbstractDTO
    {
       
        public IList<AbstractPredmet> Koristi { get; set; }

        public override string ToString()
        {
            return EntityType.Name;
        }
    }

    /// <summary>
    /// Vilenjak
    /// </summary>
    public class VilenjakDTO : RasaDTO
    {
        public int NivoEnergije { get; set; }
        
        public VilenjakDTO(Vilenjak v)
        {
            ID = v.Id;
            Koristi = v.Koristi;
            NivoEnergije = v.NivoEnergije;
            EntityType = typeof(Vilenjak);
        }

        public override object ConvertToEntity()
        {
            var v = new Vilenjak();
            v.Koristi = Koristi;
            v.NivoEnergije = NivoEnergije;
            return v;
        }
    }


    /// <summary>
    /// Ork
    /// </summary>
    public class OrkDTO : RasaDTO
    {
        public virtual string Specijalizacija { get; set; }

        public OrkDTO(Ork o)
        {
            ID = o.Id;
            Koristi = o.Koristi;
            Specijalizacija = o.Specijalizacija;
            EntityType = typeof(Ork);
        }

        public override object ConvertToEntity()
        {
            var o = new Ork();
            o.Koristi = Koristi;
            o.Specijalizacija = Specijalizacija;
            return o;
        }
    }


    /// <summary>
    /// Covek
    /// </summary>
    public class CovekDTO : RasaDTO
    {
        public virtual int UmesnostUSkrivanju { get; set; }

        public CovekDTO(Covek c)
        {
            ID = c.Id;
            Koristi = c.Koristi;
            UmesnostUSkrivanju = c.UmesnostUSkrivanju;
            EntityType = typeof(Covek);
        }

        public override object ConvertToEntity()
        {
            var c = new Covek();
            c.Koristi = Koristi;
            c.UmesnostUSkrivanju = UmesnostUSkrivanju;
            return c;
        }
    }


    /// <summary>
    /// Demon
    /// </summary>
    public class DemonDTO : RasaDTO
    {
        public int NivoEnergije { get; set; }

        public DemonDTO(Demon d)
        {
            ID = d.Id;
            Koristi = d.Koristi;
            NivoEnergije = d.NivoEnergije;
            EntityType = typeof(Demon);
        }

        public override object ConvertToEntity()
        {
            var d = new Demon();
            d.Koristi = Koristi;
            d.NivoEnergije = NivoEnergije;
            return d;
        }
    }

    /// <summary>
    /// Patuljak
    /// </summary>
    public class PatuljakDTO : RasaDTO
    {
        public string Specijalizacija { get; set; }

        public PatuljakDTO(Patuljak p)
        {
            ID = p.Id;
            Koristi = p.Koristi;
            Specijalizacija = p.Specijalizacija;
            EntityType = typeof(Patuljak);
        }

        public override object ConvertToEntity()
        {
            var p = new Patuljak();
            p.Koristi = Koristi;
            p.Specijalizacija = Specijalizacija;
            return p;
        }
    }
}
