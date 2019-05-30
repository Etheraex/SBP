using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBP_Data.Models;
using FluentNHibernate.Mapping;

namespace SBP_Data.Mappings
{
    class AlijansaMapiranje : ClassMap<Alijansa>
    {
        public AlijansaMapiranje()
        {
            Table("Alijansa");
            //Id(x => x.Id, "ALIJANSA_ID").GeneratedBy.SequenceIdentity("S16022.ALIJANSA_ID_SEQ");
            Id(x => x.Id, "ALIJANSA_ID").GeneratedBy.TriggerIdentity();
            Map(x => x.Naziv).Column("NAZIV");
            Map(x => x.MinBrojIgraca).Column("MINBROJIGRACA");
            Map(x => x.MaxBrojIgraca).Column("MAXBROJIGRACA");
            Map(x => x.HpBonus).Column("BONUS_XP");
            Map(x => x.XpBonus).Column("HP_BONUS");

            HasManyToMany(x => x.Savezi)
                .ParentKeyColumn("ALIJANSA_FK1")
                .ChildKeyColumn("ALIJANSA_FK2")
                .Table("SAVEZI");

            HasManyToMany(x => x.IspunjeniQuestiovi)
              .Table("ALIJANSAISPUNJAVA")
              .ParentKeyColumn("ALIJANSA_FK")
              .ChildKeyColumn("QUEST_FK")
              .Cascade.All();
        }
    }
}
