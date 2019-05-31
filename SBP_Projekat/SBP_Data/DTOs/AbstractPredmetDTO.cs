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
        public Quest Pripada { get; set; }
        public IList<Rasa> MozeDaKoristi { get; set; }
        public IList<Igrac> Igraci { get; set; }

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

        public PredmetDTO(Predmet p)
        {
            base.EntityType = typeof(Predmet);
            ID = p.Id;
            XpBonus = p.XpBonus;
            Naziv = p.Naziv;
            Opis = p.Opis;
            VrstaOruzja = p.VrstaOruzja;
            Pripada = p.Pripada;
            MozeDaKoristi = p.MozeDaKoristi;
            Igraci = p.Igraci;
        }

        public override object CreateOrUpdate(object input)
        {
            Predmet p = CheckStuff((Predmet)input);
            if (ID != 0)
                p.Id = ID;

            p.XpBonus = XpBonus;
            p.Naziv = Naziv;
            p.Opis = Opis;
            p.VrstaOruzja = VrstaOruzja;
            p.Pripada = Pripada;
            p.MozeDaKoristi = MozeDaKoristi;
            p.Pripada = Pripada;
            p.Igraci = Igraci;

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

        public OruzjeDTO(Oruzje o)
        {
            base.EntityType = typeof(Oruzje);
            ID = o.Id;
            XpBonus = o.XpBonus;
            Naziv = o.Naziv;
            Opis = o.Opis;
            VrstaOruzja = o.VrstaOruzja;
            Pripada = o.Pripada;
            MozeDaKoristi = o.MozeDaKoristi;
            Igraci = o.Igraci;
        }

        public override object CreateOrUpdate(object input)
        {
            Oruzje o = CheckStuff((Oruzje)input);
            if (ID != 0)
                o.Id = ID;

            o.XpBonus = XpBonus;
            o.Naziv = Naziv;
            o.Opis = Opis;
            o.VrstaOruzja = VrstaOruzja;
            o.Pripada = Pripada;
            o.MozeDaKoristi = MozeDaKoristi;
            o.Pripada = Pripada;
            o.Igraci = Igraci;

            return o;
        }
    }
}
