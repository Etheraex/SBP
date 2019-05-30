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

        }

        public override string ToString()
        {
            return EntityType.Name + XpGain;
        }

        public QuestDTO(Quest q)
        {
            base.EntityType = typeof(Quest);
            ID = q.Id;
            XpGain = q.XpGain;
            Predmeti = q.Predmeti;
            AlijanseKojeSuIspunile = q.AlijanseKojeSuIspunile;
            IgraciKojiSuIspunili = q.IgraciKojiSuIspunili;
        }

        public override object CreateOrUpdate(object input)
        {
            Quest q = null;
            if (input != null)
                q = input as Quest;
            else if (q == null || input == null)
                q = new Quest();

            q.XpGain = XpGain;
            q.Predmeti = Predmeti;
            q.AlijanseKojeSuIspunile = AlijanseKojeSuIspunile;
            q.IgraciKojiSuIspunili = IgraciKojiSuIspunili;

            return q;
        }
    }
}
