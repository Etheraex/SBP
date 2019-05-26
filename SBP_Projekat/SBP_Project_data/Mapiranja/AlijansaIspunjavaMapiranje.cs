using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBP_Project_data.Models;
namespace SBP_Project_data.Mapiranja
{
    class AlijansaIspunjavaMapiranje : ClassMap<AlijansaIspunjava>
    {
        public AlijansaIspunjavaMapiranje()
        {
            Table("AlijansaIspunjava");
            //Id(x => x.Id, "ALIJANSAISPUNJAVA_ID").GeneratedBy.SequenceIdentity("S16022.ALIJANSAISPUNJAVA_ID_SEQ");
            Id(x => x.Id, "ALIJANSAISPUNJAVA_ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Vreme).Column("VREME");
            References(x => x.Quest).Column("QUEST_FK").LazyLoad();
            References(x => x.Alijansa).Column("ALIJANSA_FK").LazyLoad();
        }
    }
}
