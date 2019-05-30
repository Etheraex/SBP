﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBP_Data.Models;


namespace SBP_Data.DTOs
{
    public class SesijaDTO : AbstractDTO
    {
        public double Gold { get; set; }
        public int ZaradjeniXP { get; set; }
        public string VremePocetka { get; set; }
        public string VremeKraja { get; set; }

        public Igrac Igrac { get; set; }
        public Lik Lik { get; set; }

        public SesijaDTO()
        {

        }

        public override string ToString()
        {
            return EntityType.Name + ZaradjeniXP;
        }

        public override object CreateOrUpdate(object input)
        {
            Sesija s = null;
            if (input != null)
                s = input as Sesija;
            else if (s == null || input == null)
                s = new Sesija();

            s.Gold = Gold;
            s.ZaradjeniXP = ZaradjeniXP;
            s.VremeKraja = VremeKraja;
            s.VremePocetka = VremePocetka;
            s.Igrac = Igrac;
            s.Lik = Lik;
            return s;
        }

        public SesijaDTO(Sesija s)
        {
            base.EntityType = typeof(Sesija);
            ID = s.Id;
            Gold = s.Gold;
            ZaradjeniXP = s.ZaradjeniXP;
            VremePocetka = s.VremePocetka;
            VremeKraja = s.VremeKraja;
        }
    }
}