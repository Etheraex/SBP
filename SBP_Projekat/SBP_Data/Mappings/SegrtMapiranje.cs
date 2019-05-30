using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBP_Data.Models;
using FluentNHibernate.Mapping;

namespace SBP_Data.Mappings
{
    class SegrtMapiranje : ClassMap<Segrt>
    {
        public SegrtMapiranje()
        {
            Table("Segrt");
            //Id(x => x.Id, "SEGRT_ID").GeneratedBy.SequenceIdentity("S16022.SEGRT_ID_SEQ");
            Id(x => x.Id, "SEGRT_ID").GeneratedBy.TriggerIdentity();
            Map(x => x.Ime).Column("IME");
            Map(x => x.Bonus).Column("BONUS");

            References(x => x.Rasa).Column("RASA_FK").LazyLoad();
            References(x => x.Lik).Column("LIK_FK").LazyLoad();
        }
    }
}
