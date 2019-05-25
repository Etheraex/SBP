using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBP_Project_data.Models;
using FluentNHibernate.Mapping;

namespace SBP_Project_data.Mapiranja
{
    public class QuestMapiranje : ClassMap<Quest>
    {
        public QuestMapiranje()
        {
            Table("Quest");
            Id(x => x.Id, "QUEST_ID").GeneratedBy.SequenceIdentity("S16022.QUEST_AUTO_PK");

            Map(x => x.XpGain).Column("XP_Gain");
        }
    }
}

