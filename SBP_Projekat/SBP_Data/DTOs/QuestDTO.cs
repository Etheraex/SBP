using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBP_Data.Models;

namespace SBP_Data.DTOs
{
    public class QuestDTO : AbstractDTO
    {
        public int XpGain { get; set; }
        public IList<Predmet> Predmeti { get; set; }
        public IList<Alijansa> AlijanseKojeSuIspunile { get; set; } 
        public IList<Igrac> IgraciKojiSuIspunili { get; set; }

        public QuestDTO()
        {
            base.EntityType = typeof(Quest);
        }

        public override string ToString()
        {
            return EntityType.Name + XpGain;
        }

        public QuestDTO(Quest q)
        {
            if (q != null)
            {
                base.EntityType = typeof(Quest);
                ID = q.Id;
                XpGain = q.XpGain;
                Predmeti = q.Predmeti;
                AlijanseKojeSuIspunile = q.AlijanseKojeSuIspunile;
                IgraciKojiSuIspunili = q.IgraciKojiSuIspunili;
            }
            else
                throw new NullReferenceException();
        }

        public override object CreateOrUpdate(object input)
        {
            Quest q = CheckStuff((Quest)input);
            if (ID != 0)
                q.Id = ID;

            q.XpGain = XpGain;
            q.Predmeti = Predmeti;
            q.AlijanseKojeSuIspunile = AlijanseKojeSuIspunile;
            q.IgraciKojiSuIspunili = IgraciKojiSuIspunili;

            return q;
        }
    }
}
