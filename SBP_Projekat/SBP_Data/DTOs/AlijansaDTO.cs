using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBP_Data.Models;

namespace SBP_Data.DTOs
{
    public class AlijansaDTO : AbstractDTO
    {
        public string Naziv { get; set; }
        public int MinBrojIgraca { get; set; }
        public int MaxBrojIgraca { get; set; }
        public int XpBonus { get; set; }
        public int HpBonus { get; set; }

        public IList<AlijansaDTO> Savezi { get; set; }
        public IList<IgracDTO> Igraci { get; set; }
        public IList<QuestDTO> IspunjeniQuestiovi { get; set; }

        public AlijansaDTO()
        {
            base.EntityType = typeof(Alijansa);
            Savezi = new List<AlijansaDTO>();
            Igraci = new List<IgracDTO>();
            IspunjeniQuestiovi = new List<QuestDTO>();
        }

        public override string ToString()
        {
            return EntityType.Name + Naziv;
        }

        public AlijansaDTO(Alijansa a,bool include = true)
        {
            if (a != null)
            {
                base.EntityType = typeof(Alijansa);
                ID = a.Id;
                Naziv = a.Naziv;
                MinBrojIgraca = a.MinBrojIgraca;
                MaxBrojIgraca = a.MaxBrojIgraca;
                XpBonus = a.XpBonus;
                HpBonus = a.HpBonus;
         
                Savezi = new List<AlijansaDTO>();
               
                Igraci = new List<IgracDTO>();
               
                IspunjeniQuestiovi = new List<QuestDTO>();
              
                if (include)
                {
                    foreach (var i in a.Savezi)
                    {
                        Savezi.Add(new AlijansaDTO(i, false));
                    }
                    foreach (var item in a.Igraci)
                    {
                        Igraci.Add(new IgracDTO(item,false));
                    }
                    foreach (var item in a.IspunjeniQuestiovi)
                    {
                        IspunjeniQuestiovi.Add(new QuestDTO(item,false));
                    }
                }
            }
            else
                throw new NullReferenceException();
        }

        public override object CreateOrUpdate(object input)
        {
            Alijansa a = CheckStuff((Alijansa)input);
            if (ID != 0)
                a.Id = ID;

            a.Naziv = Naziv;
            a.MinBrojIgraca = MinBrojIgraca;
            a.MaxBrojIgraca = MaxBrojIgraca;
            a.XpBonus = XpBonus;
            a.HpBonus = HpBonus;
          

            return a;
        }
    }   
}
