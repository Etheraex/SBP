using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBP_Data.Models;

namespace SBP_Data.Mappings
{
    class SesijaMapiranje : ClassMap<Sesija>
    {
        public SesijaMapiranje()
        {
            Table("SESIJA");
            Id(x => x.Id, "SESIJA_ID").GeneratedBy.TriggerIdentity();
            Map(x => x.Gold).Column("GOLD");
            Map(x => x.ZaradjeniXP).Column("ZARADJEN_XP");
            Map(x => x.VremeKraja).Column("VREMEKRAJA");
            Map(x => x.VremePocetka).Column("VREMEPOCETKA");

            References(x => x.Igrac).Column("IGRAC_FK").LazyLoad();
            References(x => x.Lik).Column("LIK_FK").LazyLoad();
        }
    }
}
