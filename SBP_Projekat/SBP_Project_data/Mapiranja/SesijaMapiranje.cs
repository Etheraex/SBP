using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBP_Project_data.Models;

namespace SBP_Project_data.Mapiranja
{
    class SesijaMapiranje : ClassMap<Sesija>
    {
        public SesijaMapiranje()
        {
            Table("SESIJA");
            Id(x => x.Id, "SESIJA_ID").GeneratedBy.SequenceIdentity("S16022.SESIJA_AUTO_PK");
            /*CompositeId(x => x.Id)
                .KeyReference(x => x.Igrac, "IGRAC_FK")
                .KeyReference(x => x.Lik, "LIK_FK");*/
            Map(x => x.Gold).Column("GOLD");
            Map(x => x.ZaradjeniXP).Column("ZARADJEN_XP");
            Map(x => x.VremeKraja).Column("VREMEKRAJA");
            Map(x => x.VremePocetka).Column("VREMEPOCETKA");

            References(x => x.Igrac).Column("IGRAC_FK").LazyLoad();
            References(x => x.Lik).Column("LIK_FK").LazyLoad();
        }
    }
}
