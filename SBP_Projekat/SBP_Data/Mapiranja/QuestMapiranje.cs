using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBP_Data.Models;
using FluentNHibernate.Mapping;

namespace SBP_Data.Mapiranja
{
    public class QuestMapiranje : ClassMap<Quest>
    {
        public QuestMapiranje()
        {
            Table("Quest");
            //Id(x => x.Id, "QUEST_ID").GeneratedBy.SequenceIdentity("S16022.QUEST_ID_SEQ");
            Id(x => x.Id, "QUEST_ID").GeneratedBy.TriggerIdentity();
            HasManyToMany(x => x.AlijanseKojeSuIspunile)
               .Table("ALIJANSAISPUNJAVA")
               .ParentKeyColumn("QUEST_FK")
               .ChildKeyColumn("ALIJANSA_FK")
               .Inverse()
               .Cascade.All();
            HasManyToMany(x => x.IgraciKojiSuIspunili)
              .Table("IGRACISPUNJAVA")
              .ParentKeyColumn("QUEST_FK")
              .ChildKeyColumn("IGRAC_FK")
              .Inverse()
              .Cascade.All();
            Map(x => x.XpGain).Column("XP_Gain");
        }
    }
}

