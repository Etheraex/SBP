using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBP_Project_data.Models;
using FluentNHibernate.Mapping;

namespace SBP_Project_data.Mapiranja
{
    class AbstractPredmetMapiranje : ClassMap<AbstractPredmet>
    {
        public AbstractPredmetMapiranje()
        {
            Table("Predmet");
            Id(x => x.Id, "PREDMET_ID").GeneratedBy.SequenceIdentity("S16022.PREDMET_ID_SEQ");
            Map(x => x.Naziv).Column("NAZIV");
            Map(x => x.Opis).Column("OPIS");
            Map(x => x.XpBonus).Column("XP_BONUS");
            Map(x => x.VrstaOruzja).Column("VRSTAORUZIJA");
            References(x => x.Pripada).Column("QUEST_FK").LazyLoad();
            HasManyToMany(x => x.MozeDaKoristi)
                .Table("KORISTI")
                .ParentKeyColumn("PREDMET_FK")
                .ChildKeyColumn("RASA_FK")
                .Cascade.All();
            HasManyToMany(x => x.Igraci)
                .Table("POSEDUJE")
                .ParentKeyColumn("PREDMET_FK")
                .ChildKeyColumn("IGRAC_FK")
                .Inverse()
                .Cascade.All();
            DiscriminateSubClassesOnColumn("TIPPREDMETA");
        }
    }

    class PredmetMapiranje : SubclassMap<Predmet>
    {
        public PredmetMapiranje()
        {
            DiscriminatorValue("predmet");
        }
    }


    class OruzjeMapiranje : SubclassMap<Oruzje>
    {
        public OruzjeMapiranje()
        {
            DiscriminatorValue("oruzje");
        }
    }
}
