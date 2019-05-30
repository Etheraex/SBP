using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBP_Data.Models;
using FluentNHibernate.Mapping;
namespace SBP_Data.Mappings
{
    class IgracIspunjavaMapiranje : ClassMap<IgracIspunjava>
    {
        public IgracIspunjavaMapiranje()
        {
            Table("IgracIspunjava");
            Id(x => x.Id, "IGRACISPUNJAVA_ID").GeneratedBy.TriggerIdentity();
            Map(x => x.Vreme).Column("VREME");
            References(x => x.Quest).Column("QUEST_FK").LazyLoad();
            References(x => x.Igrac).Column("IGRAC_FK").LazyLoad();
        }
        
    }
}
