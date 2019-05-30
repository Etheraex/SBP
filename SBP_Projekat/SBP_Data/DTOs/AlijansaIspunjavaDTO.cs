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

        public override string ToString()
        {
            return EntityType.Name + Vreme;
        }

        public AlijansaIspunjavaDTO(AlijansaIspunjava a)
        {
            base.EntityType = typeof(AlijansaIspunjava);
            ID = a.Id;
            Vreme = a.Vreme;
            Alijansa = a.Alijansa;
            Quest = a.Quest;
        }

        public override object CreateOrUpdate(object input)
        {
            AlijansaIspunjava a = null;
            if (input != null)
                a = input as AlijansaIspunjava;
            else if (a == null || input == null)
            {
                a = new AlijansaIspunjava();
            }
            a.Vreme = Vreme;
            a.Alijansa = Alijansa;
            a.Quest = Quest;
            return a;
        }
    }
}
