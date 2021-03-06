﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBP_Data.Models;

namespace SBP_Data.DTOs
{
    public class AbstractPredmetDTO : AbstractDTO 
    {
        public int XpBonus { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string VrstaOruzja { get; set; }
        public QuestDTO Pripada { get; set; }
        public IList<RasaDTO> MozeDaKoristi { get; set; }
        public IList<IgracDTO> Igraci { get; set; }

        public AbstractPredmetDTO()
        {

        }

        public override object CreateOrUpdate(object input)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return EntityType.Name + Naziv;
        }
    }

    /// <summary>
    /// Predmet
    /// </summary>
    public class PredmetDTO : AbstractPredmetDTO
    {
        public PredmetDTO()
        {
            base.EntityType = typeof(Predmet);
        }

        public PredmetDTO(Predmet p,bool include=true)
        {
            if (p != null)
            {
                base.EntityType = typeof(Predmet);
                ID = p.Id;
                XpBonus = p.XpBonus;
                Naziv = p.Naziv;
                Opis = p.Opis;
                VrstaOruzja = p.VrstaOruzja;
                if (p.Pripada != null && include)
                    this.Pripada = new QuestDTO(p.Pripada, false);
                MozeDaKoristi = new List<RasaDTO>();
                Igraci = new List<IgracDTO>();

                if (include)
                {
                    foreach (var item in p.Igraci)
                    {
                        Igraci.Add(new IgracDTO(item, false));
                    }
                    foreach (var item in p.MozeDaKoristi)
                    {
                        MozeDaKoristi.Add(DTOManager.Instance.vratiRasuDTO(item)); // DTOMANAGER FJA KOJA VRACA RASU odnosno njen naziv makar
                    }
                }

            }
            else
                throw new NullReferenceException();
        }

        public override object CreateOrUpdate(object input)
        {
            Predmet p = CheckStuff((Predmet)input);
            if (ID != 0)
            {
                p.Id = ID;
                Predmet old = DTOManager.Instance.GetEntityById<PredmetDTO, Predmet>(ID);
                p.MozeDaKoristi = old.MozeDaKoristi;
                p.Igraci = old.Igraci;
                p.Pripada = old.Pripada;
            }

            p.XpBonus = XpBonus;
            p.Naziv = Naziv;
            p.Opis = Opis;
            p.VrstaOruzja = VrstaOruzja;

    

            return p;
        }
    }

    /// <summary>
    /// Oruzje
    /// </summary>
    public class OruzjeDTO : AbstractPredmetDTO
    {
        public OruzjeDTO()
        {
            base.EntityType = typeof(Oruzje);
        }

        public OruzjeDTO(Oruzje o,bool include = true)
        {
            if (o != null)
            {
                base.EntityType = typeof(Oruzje);
                ID = o.Id;
                XpBonus = o.XpBonus;
                Naziv = o.Naziv;
                Opis = o.Opis;
                VrstaOruzja = o.VrstaOruzja;

                if (o.Pripada!= null && include)
                    this.Pripada = new QuestDTO(o.Pripada, false);
                
                MozeDaKoristi = new List<RasaDTO>();
                Igraci = new List<IgracDTO>();
                if (include)
                {
                    foreach (var item in o.Igraci)
                    {
                        Igraci.Add(new IgracDTO(item, false));
                    }
                    foreach (var item in o.MozeDaKoristi)
                    {
                        MozeDaKoristi.Add(DTOManager.Instance.vratiRasuDTO(item)); // DTOMANAGER FJA KOJA VRACA RASU odnosno njen naziv makar
                    }
                }
            }
            else
                throw new NullReferenceException();
        }

        public override object CreateOrUpdate(object input)
        {
            Oruzje o = CheckStuff((Oruzje)input);
            if (ID != 0)
            {
                o.Id = ID;
                Oruzje old = DTOManager.Instance.GetEntityById<OruzjeDTO, Oruzje>(ID);
                o.MozeDaKoristi = old.MozeDaKoristi;
                o.Igraci = old.Igraci;
                o.Pripada = old.Pripada;
            }

            o.XpBonus = XpBonus;
            o.Naziv = Naziv;
            o.Opis = Opis;
            o.VrstaOruzja = VrstaOruzja;

   

            return o;
        }
    }
}
