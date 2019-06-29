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
        public IgracDTO Igrac { get; set; }
        public QuestDTO Quest { get; set; }

        public IgracIspunjavaDTO()
        {
            base.EntityType = typeof(IgracIspunjava);
        }

        public override string ToString()
        {
            return EntityType.Name + Vreme;
        }

        public IgracIspunjavaDTO(IgracIspunjava i,bool include=true)
        {
            if (i != null)
            {
                base.EntityType = typeof(IgracIspunjava);
                ID = i.Id;
                Vreme = i.Vreme;
                if (include)
                {
                    Igrac = new IgracDTO(i.Igrac);
                    Quest = new QuestDTO(i.Quest);
                }
             
            }
            else
                throw new NullReferenceException();
        }

        public override object CreateOrUpdate(object input)
        {
            IgracIspunjava i = CheckStuff((IgracIspunjava)input);
            if (ID != 0)
            {
                i.Id = ID;
                IgracIspunjava old = DTOManager.Instance.GetEntityById<IgracIspunjavaDTO, IgracIspunjava>(ID);
                i.Quest = old.Quest;
                i.Igrac = old.Igrac;
            }

            i.Vreme = Vreme;
     

            return i;
        }
    }
}
