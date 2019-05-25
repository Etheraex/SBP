using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBP_Project_data.Models;
using FluentNHibernate.Mapping;

namespace SBP_Project_data.Mapiranja
{
    class AlijansaMapiranje : ClassMap<Alijansa>
    {
        public AlijansaMapiranje()
        {
            Table("Alijansa");
            Id(x => x.Id, "ALIJANSA_ID").GeneratedBy.SequenceIdentity("S16022.ALIJANSA_AUTO_PK");
            Map(x => x.Naziv).Column("NAZIV");
            Map(x => x.MinBrojIgraca).Column("MINBROJIGRACA");
            Map(x => x.MaxBrojIgraca).Column("MAXBROJIGRACA");
            Map(x => x.HpBonus).Column("BONUS_XP");
            Map(x => x.XpBonus).Column("HP_BONUS");

            HasManyToMany(x => x.Savezi)
                .ParentKeyColumn("ALIJANSA_FK1")
                .ChildKeyColumn("ALIJANSA_FK2")
                .Table("SAVEZI");
        }
    }
}
