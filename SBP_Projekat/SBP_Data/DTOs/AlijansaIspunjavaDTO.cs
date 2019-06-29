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
        public AlijansaDTO Alijansa { get; set; }
        public QuestDTO Quest { get; set; }

        public AlijansaIspunjavaDTO()
        {
            base.EntityType = typeof(AlijansaIspunjava);
        }

        public override string ToString()
        {
            return EntityType.Name + Vreme;
        }

        public AlijansaIspunjavaDTO(AlijansaIspunjava a,bool include = true)
        {
            if (a != null)
            {
                base.EntityType = typeof(AlijansaIspunjava);
                ID = a.Id;
                Vreme = a.Vreme;
                if (include)
                {
                    Alijansa = new AlijansaDTO(a.Alijansa);
                    Quest = new QuestDTO(a.Quest);
                }
               
            }
            else
                throw new NullReferenceException();
        }

        public override object CreateOrUpdate(object input)
        {
            AlijansaIspunjava a = CheckStuff((AlijansaIspunjava)input);
            if (ID != 0)
            {
                a.Id = ID;
                AlijansaIspunjava old = DTOManager.Instance.GetEntityById<AlijansaIspunjavaDTO, AlijansaIspunjava>(ID);
                a.Quest = old.Quest;
                a.Alijansa = old.Alijansa;
            }

            a.Vreme = Vreme;

            return a;
        }
    }
}
