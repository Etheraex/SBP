using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBP_Project_data.Models;
using FluentNHibernate.Mapping;

namespace SBP_Project_data.Mapiranja
{
    class IgracMapiranje : ClassMap<Igrac>
    {
        public IgracMapiranje()
        {
            Table("Igrac");

            Id(x => x.Id, "IGRAC_ID").GeneratedBy.SequenceIdentity("S16022.IGRAC_ID_SEQ");
            Map(x => x.Username).Column("USERNAME");
            Map(x => x.Password).Column("PASSWORD");
            Map(x => x.Uzrast).Column("UZRAST");
            Map(x => x.Nadimak).Column("NADIMAK");
            Map(x => x.Pol).Column("POL");
            Map(x => x.Ime).Column("IME");
            Map(x => x.Prezime).Column("PREZIME");
            References(x => x.PripadaAlijansi).Column("ALIJANSA_FK");
            HasManyToMany(x => x.Predmeti)
                .Table("POSEDUJE")
                .ParentKeyColumn("IGRAC_FK")
                .ChildKeyColumn("PREDMET_FK")
                .Cascade.All();
            HasManyToMany(x => x.IspunjeniQuestiov)
              .Table("IGRACISPUNJAVA")
              .ParentKeyColumn("IGRAC_FK")
              .ChildKeyColumn("QUEST_FK")
              .Cascade.All();
        }
    }
}
