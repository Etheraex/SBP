﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBP_Project_data.Models;
using FluentNHibernate.Mapping;
namespace SBP_Project_data.Mapiranja
{
    public class RasaMapiranje : ClassMap<Rasa>
    {
        public RasaMapiranje()
        {
            Table("Rasa");
            Id(x => x.Id, "RASA_ID").GeneratedBy.SequenceIdentity("S16022.RASA_ID_SEQ");
            DiscriminateSubClassesOnColumn("TIPRASE");
        }
    }

    class CovekMapiranje : SubclassMap<Covek>
    {
        public CovekMapiranje()
        {
            DiscriminatorValue("Covek");

            Map(x => x.UmesnostUSkrivanju).Column("UMESNOSTUSKRIVANJU");
        }
    }
    class BoracMapiranje : SubclassMap<Borac>
    {
        public BoracMapiranje()
        {
            Map(x => x.Specijalizacija).Column("SPECIJALIZACIJA");
        }
    }
    class MageMapiranje : SubclassMap<Mage>
    {
        public MageMapiranje()
        {
            Map(x => x.NivoEnergije).Column("NIVOENERGIJE");
        }
    }
    class PatuljakMapiranje : SubclassMap<Patuljak>
    {
        public PatuljakMapiranje()
        {
           
            DiscriminatorValue("Patuljak");
        }
    }
    class OrkMapiranje : SubclassMap<Ork>
    {
        public OrkMapiranje()
        {
            DiscriminatorValue("ork");
        }
    }
    class VilenjakMapiranje : SubclassMap<Vilenjak>
    {
        public VilenjakMapiranje()
        {
            DiscriminatorValue("vilenjak");
        }
    }
    class DemonMapiranje : SubclassMap<Demon>
    {
        public DemonMapiranje()
        {
            DiscriminatorValue("demon");
        }
    }
}