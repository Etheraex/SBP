using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBP_Data.Models;
namespace SBP_Data.Mappings
{
    class AlijansaIspunjavaMapiranje : ClassMap<AlijansaIspunjava>
    {
        public AlijansaIspunjavaMapiranje()
        {
            Table("AlijansaIspunjava");
            Id(x => x.Id, "ALIJANSAISPUNJAVA_ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Vreme).Column("VREME");
            References(x => x.Quest).Column("QUEST_FK").LazyLoad();
            References(x => x.Alijansa).Column("ALIJANSA_FK").LazyLoad();
        }
    }
}
