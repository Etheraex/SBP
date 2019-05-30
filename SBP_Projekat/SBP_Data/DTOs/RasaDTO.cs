﻿using System;
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

        public VilenjakDTO()
        {

        }

        public VilenjakDTO(Vilenjak v)
        {
            ID = v.Id;
            Koristi = v.Koristi;
            NivoEnergije = v.NivoEnergije;
            EntityType = typeof(Vilenjak);
        }

        public override object CreateOrUpdate(object input)
        {
            Vilenjak i = null;
            if (input != null)
                i = input as Vilenjak;
            else if (i == null || input == null)
                i = new Vilenjak();

            i.Koristi = Koristi;
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

        }

        public OrkDTO(Ork o)
        {
            ID = o.Id;
            Koristi = o.Koristi;
            Specijalizacija = o.Specijalizacija;
            EntityType = typeof(Ork);
        }

        public override object CreateOrUpdate(object input)
        {
            Ork i = null;
            if (input != null)
                i = input as Ork;
            else if (i == null || input == null)
                i = new Ork();

            i.Koristi = Koristi;
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

        }

        public CovekDTO(Covek c)
        {
            ID = c.Id;
            Koristi = c.Koristi;
            UmesnostUSkrivanju = c.UmesnostUSkrivanju;
            EntityType = typeof(Covek);
        }

        public override object CreateOrUpdate(object input)
        {
            Covek i = null;
            if (input != null)
                i = input as Covek;
            else if (i == null || input == null)
                i = new Covek();

            i.Koristi = Koristi;
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

        }

        public DemonDTO(Demon d)
        {
            ID = d.Id;
            Koristi = d.Koristi;
            NivoEnergije = d.NivoEnergije;
            EntityType = typeof(Demon);
        }

        public override object CreateOrUpdate(object input)
        {
            Demon i = null;
            if (input != null)
                i = input as Demon;
            else if (i == null || input == null)
                i = new Demon();

            i.Koristi = Koristi;
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

        }

        public PatuljakDTO(Patuljak p)
        {
            ID = p.Id;
            Koristi = p.Koristi;
            Specijalizacija = p.Specijalizacija;
            EntityType = typeof(Patuljak);
        }
        public override object CreateOrUpdate(object input)
        {
            Patuljak i = null;
            if (input != null)
                i = input as Patuljak;
            else if (i == null || input == null)
                i = new Patuljak();

            i.Koristi = Koristi;
            i.Specijalizacija = Specijalizacija;
            return i;
        }
    }
}