﻿using System;
using Newtonsoft.Json;
using SBP_Data.Models;

namespace SBP_Data.DTOs
{
    public class SesijaDTO : AbstractDTO
    {
        public double Gold { get; set; }
        public int ZaradjeniXP { get; set; }
        public string VremePocetka { get; set; }
        public string VremeKraja { get; set; }

        public IgracDTO Igrac { get; set; }
        public LikDTO Lik { get; set; }

        [JsonIgnore]
        public string IgracNaziv
        {
            get
            {
                return (Igrac != null)?Igrac.Nadimak:"";
            }
        }

        [JsonIgnore]
        public string LikRasa
        {
            get
            {
                return (Lik.Rasa != null)?Lik.Rasa.GetType().Name : "";
            }
        }

        public SesijaDTO()
        {
            EntityType = typeof(Sesija);
        }

        public override string ToString()
        {
            return EntityType.Name + ZaradjeniXP;
        }

        public override object CreateOrUpdate(object input)
        {
            Sesija s = CheckStuff((Sesija)input);
            if (ID != 0)
            {
                s.Id = ID;
                Sesija old = DTOManager.Instance.GetEntityById<SesijaDTO, Sesija>(ID);
                s.Igrac = old.Igrac;
                s.Lik = old.Lik;
            }

            s.Gold = Gold;
            s.ZaradjeniXP = ZaradjeniXP;
            s.VremeKraja = VremeKraja;
            s.VremePocetka = VremePocetka;
            s.Igrac = DTOManager.Instance.GetEntityById<IgracDTO, Igrac>(Igrac.ID);
            s.Lik = DTOManager.Instance.GetEntityById<LikDTO, Lik>(Lik.ID);
            return s;
        }

        public SesijaDTO(Sesija s, bool include = true)
        {
            if (s != null)
            {
                base.EntityType = typeof(Sesija);
                ID = s.Id;
                Gold = s.Gold;
                if (s.Igrac != null && include)
                    Igrac = new IgracDTO(s.Igrac, false);

                if (s.Lik != null && include)
                    Lik = new LikDTO(s.Lik, false);
                ZaradjeniXP = s.ZaradjeniXP;
                VremePocetka = s.VremePocetka;
                VremeKraja = s.VremeKraja;
            }
            else
                throw new NullReferenceException();
        }
    }
}
