using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBP_Project_data.Models;
using FluentNHibernate.Mapping;

namespace SBP_Project_data.Mapiranja
{
    class LikMapiranje : ClassMap<Lik>
    {
        public LikMapiranje()
        {
            Table("LIK");
            Id(x => x.Id, "LIK_ID").GeneratedBy.SequenceIdentity("S16022.LIK_ID_SEQ");

            Map(x => x.HP).Column("HP");
            Map(x => x.XP).Column("XP");
            Map(x => x.Zlato).Column("ZLATO");
            Map(x => x.StepenZamora).Column("STEPEN_ZAMORA");
            References(x => x.Rasa).Column("RASA_FK").LazyLoad();
        }
    }
}
