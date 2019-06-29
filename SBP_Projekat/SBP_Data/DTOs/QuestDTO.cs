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
        public IList<PredmetDTO> Predmeti { get; set; }
        public IList<AlijansaDTO> AlijanseKojeSuIspunile { get; set; } 
        public IList<IgracDTO> IgraciKojiSuIspunili { get; set; }

        public QuestDTO()
        {
            base.EntityType = typeof(Quest);
        }

        public override string ToString()
        {
            return EntityType.Name + XpGain;
        }

        public QuestDTO(Quest q, bool include = true)
        {
            if (q != null)
            {
                base.EntityType = typeof(Quest);
                ID = q.Id;
                XpGain = q.XpGain;
                Predmeti = new List<PredmetDTO>();
                AlijanseKojeSuIspunile = new List<AlijansaDTO>();
                IgraciKojiSuIspunili = new List<IgracDTO>();
                if (include)
                {
                    foreach (var a in q.Predmeti)
                    {
                        {
                            Predmeti.Add(new PredmetDTO(a));
                        }
                    }
                    foreach (var a in q.AlijanseKojeSuIspunile)
                    {
                        {
                            AlijanseKojeSuIspunile.Add(new AlijansaDTO(a));
                        }
                    }
                    foreach (var a in q.IgraciKojiSuIspunili)
                    {
                        {
                            IgraciKojiSuIspunili.Add(new IgracDTO(a));
                        }
                    }
                }
            }
            else
                throw new NullReferenceException();
        }

        public override object CreateOrUpdate(object input)
        {
            Quest q = CheckStuff((Quest)input);
            if (ID != 0)
            {
                q.Id = ID;
                Quest old = DTOManager.Instance.GetEntityById<QuestDTO, Quest>(ID);
                q.Predmeti = old.Predmeti;
                q.AlijanseKojeSuIspunile = old.AlijanseKojeSuIspunile;
                q.IgraciKojiSuIspunili = old.IgraciKojiSuIspunili;
            }

            q.XpGain = XpGain;
          

            return q;
        }
    }
}
