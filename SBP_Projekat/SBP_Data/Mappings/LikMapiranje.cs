using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBP_Data.Models;
using FluentNHibernate.Mapping;

namespace SBP_Data.Mappings
{
    class LikMapiranje : ClassMap<Lik>
    {
        public LikMapiranje()
        {
            Table("LIK");
            Id(x => x.Id, "LIK_ID").GeneratedBy.TriggerIdentity();

            Map(x => x.HP).Column("HP");
            Map(x => x.XP).Column("XP");
            Map(x => x.Zlato).Column("ZLATO");
            Map(x => x.StepenZamora).Column("STEPEN_ZAMORA");
            References(x => x.Rasa).Column("RASA_FK").LazyLoad();//.Cascade.All();
            References(x => x.Igrac).Column("IGRAC_FK").LazyLoad();
        }
    }
}
