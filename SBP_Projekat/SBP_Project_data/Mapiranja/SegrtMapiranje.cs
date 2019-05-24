﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBP_Project_data.Models;
using FluentNHibernate.Mapping;

namespace SBP_Project_data.Mapiranja
{
    class SegrtMapiranje : ClassMap<Segrt>
    {
        public SegrtMapiranje()
        {
            Table("Segrt");
            Id(x => x.Id, "SEGRT_ID").GeneratedBy.SequenceIdentity("S16022.RASA_ID_SEQ");
            Map(x => x.Ime).Column("IME");
            Map(x => x.Bonus).Column("BONUS");

            References(x => x.Rasa).Column("RASA_FK").LazyLoad();
        }
    }
}