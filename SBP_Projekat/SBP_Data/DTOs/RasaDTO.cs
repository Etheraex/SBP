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
        public IList<AbstractPredmetDTO> Koristi { get; set; }

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

        public VilenjakDTO()
        {
            base.EntityType = typeof(Vilenjak);
        }

        public VilenjakDTO(Vilenjak v,bool include=true)
        {
            if (v != null)
            {
                base.EntityType = typeof(Vilenjak);
                ID = v.Id;
               
                NivoEnergije = v.NivoEnergije;
                EntityType = typeof(Vilenjak);
                //if include add, dodaj nekad za sve rase pls neko
                Koristi = new List<AbstractPredmetDTO>();
            }
            else
                throw new NullReferenceException();
        }

        public override object CreateOrUpdate(object input)
        {
            Vilenjak i = CheckStuff((Vilenjak)input);
            if (ID != 0)
            {
                i.Id = ID;
                Vilenjak old = DTOManager.Instance.GetEntityById<VilenjakDTO, Vilenjak>(ID);
                i.Koristi = old.Koristi;
            }


            i.NivoEnergije = NivoEnergije;
            return i;

        }
    }

    /// <summary>
    /// Ork
    /// </summary>
    public class OrkDTO : RasaDTO
    {
        public virtual string Specijalizacija { get; set; }

        public OrkDTO()
        {
            base.EntityType = typeof(Ork);
        }

        public OrkDTO(Ork o, bool include = true)
        {
            if (o != null)
            {
                base.EntityType = typeof(Ork);
                ID = o.Id;
                 Koristi = new List<AbstractPredmetDTO>();
                Specijalizacija = o.Specijalizacija;
                EntityType = typeof(Ork);
            }
            else
                throw new NullReferenceException();
        }

        public override object CreateOrUpdate(object input)
        {
            Ork i = CheckStuff((Ork)input);
            if (ID != 0)
            {
                i.Id = ID;
                Ork old = DTOManager.Instance.GetEntityById<OrkDTO, Ork>(ID);
                i.Koristi = old.Koristi;
            }


            i.Specijalizacija = Specijalizacija;
            return i;
        }
    }

    /// <summary>
    /// Covek
    /// </summary>
    public class CovekDTO : RasaDTO
    {
        public virtual int UmesnostUSkrivanju { get; set; }

        public CovekDTO()
        {
            base.EntityType = typeof(Covek);
        }

        public CovekDTO(Covek c, bool include = true)
        {
            if (c != null)
            {
                base.EntityType = typeof(Covek);
                ID = c.Id;
                Koristi = new List<AbstractPredmetDTO>();
                UmesnostUSkrivanju = c.UmesnostUSkrivanju;
                EntityType = typeof(Covek);
            }
            else
                throw new NullReferenceException();
        }

        public override object CreateOrUpdate(object input)
        {
            Covek i = CheckStuff((Covek)input);
            if (ID != 0)
            {
                i.Id = ID;
                Covek old = DTOManager.Instance.GetEntityById<CovekDTO, Covek>(ID);
                i.Koristi = old.Koristi;
            }


            i.UmesnostUSkrivanju = UmesnostUSkrivanju;
            return i;
        }
    }

    /// <summary>
    /// Demon
    /// </summary>
    public class DemonDTO : RasaDTO
    {
        public int NivoEnergije { get; set; }

        public DemonDTO()
        {
            base.EntityType = typeof(Demon);
        }

        public DemonDTO(Demon d, bool include = true)
        {
            if (d != null)
            {
                base.EntityType = typeof(Demon);
                ID = d.Id;
                Koristi = new List<AbstractPredmetDTO>();
                NivoEnergije = d.NivoEnergije;
                EntityType = typeof(Demon);
            }
            else
                throw new NullReferenceException();
        }

        public override object CreateOrUpdate(object input)
        {
            Demon i = CheckStuff((Demon)input);
            if (ID != 0)
            {
                i.Id = ID;
                Demon old = DTOManager.Instance.GetEntityById<DemonDTO, Demon>(ID);
                i.Koristi = old.Koristi;
            }

            Koristi = new List<AbstractPredmetDTO>();
            i.NivoEnergije = NivoEnergije;
            return i;
        }
    }

    /// <summary>
    /// Patuljak
    /// </summary>
    public class PatuljakDTO : RasaDTO
    {
        public string Specijalizacija { get; set; }

        public PatuljakDTO()
        {
            base.EntityType = typeof(Patuljak);
        }

        public PatuljakDTO(Patuljak p, bool include = true)
        {
            if (p != null)
            {
                base.EntityType = typeof(Patuljak);
                ID = p.Id;
                Koristi = new List<AbstractPredmetDTO>();
                Specijalizacija = p.Specijalizacija;
                EntityType = typeof(Patuljak);
            }
            else
                throw new NullReferenceException();
        }
        public override object CreateOrUpdate(object input)
        {
            Patuljak i = CheckStuff((Patuljak)input);
            if (ID != 0)
            {
                i.Id = ID;
                Patuljak old = DTOManager.Instance.GetEntityById<PatuljakDTO, Patuljak>(ID);
                i.Koristi = old.Koristi;
            }

            Koristi = new List<AbstractPredmetDTO>();
            i.Specijalizacija = Specijalizacija;
            return i;
        }
    }
}
