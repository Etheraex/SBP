using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBP_Data.Models;

namespace SBP_Data.DTOs
{
    public class IgracIspunjavaDTO : AbstractDTO
    {
        public int Vreme { get; set; }
        public Igrac Igrac { get; set; }
        public Quest Quest { get; set; }

        public IgracIspunjavaDTO()
        {
            base.EntityType = typeof(IgracIspunjava);
        }

        public override string ToString()
        {
            return EntityType.Name + Vreme;
        }

        public IgracIspunjavaDTO(IgracIspunjava i)
        {
            if (i != null)
            {
                base.EntityType = typeof(IgracIspunjava);
                ID = i.Id;
                Vreme = i.Vreme;
                Igrac = i.Igrac;
                Quest = i.Quest;
            }
            else
                throw new NullReferenceException();
        }

        public override object CreateOrUpdate(object input)
        {
            IgracIspunjava i = CheckStuff((IgracIspunjava)input);
            if (ID != 0)
                i.Id = ID;

            i.Vreme = Vreme;
            i.Igrac = Igrac;
            i.Quest = Quest;

            return i;
        }
    }
}
