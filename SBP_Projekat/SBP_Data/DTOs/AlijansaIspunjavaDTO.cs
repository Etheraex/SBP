using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBP_Data.Models;

namespace SBP_Data.DTOs
{
    public class AlijansaIspunjavaDTO : AbstractDTO
    {
        public int Vreme { get; set; }
        public Alijansa Alijansa { get; set; }
        public Quest Quest { get; set; }

        public AlijansaIspunjavaDTO()
        {
            base.EntityType = typeof(AlijansaIspunjava);
        }

        public override string ToString()
        {
            return EntityType.Name + Vreme;
        }

        public AlijansaIspunjavaDTO(AlijansaIspunjava a)
        {
            if (a != null)
            {
                base.EntityType = typeof(AlijansaIspunjava);
                ID = a.Id;
                Vreme = a.Vreme;
                Alijansa = a.Alijansa;
                Quest = a.Quest;
            }
            else
                throw new NullReferenceException();
        }

        public override object CreateOrUpdate(object input)
        {
            AlijansaIspunjava a = CheckStuff((AlijansaIspunjava)input);
            if (ID != 0)
                a.Id = ID;

            a.Vreme = Vreme;
            a.Alijansa = Alijansa;
            a.Quest = Quest;
            return a;
        }
    }
}
