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

        public IList<string> Savezi { get; set; }
        public IList<string> Igraci { get; set; }
        public IList<string> IspunjeniQuestiovi { get; set; }

        public AlijansaDTO()
        {
            base.EntityType = typeof(Alijansa);
            Savezi = new List<string>();
            Igraci = new List<string>();
            IspunjeniQuestiovi = new List<string>();
        }

        public override string ToString()
        {
            return EntityType.Name + Naziv;
        }

        public AlijansaDTO(Alijansa a)
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
                Savezi = new List<string>();
                foreach (var i in a.Savezi)
                {
                    Savezi.Add(i.Naziv);
                }
                Igraci = new List<string>();
                foreach ( var item in a.Igraci)
                {
                    Igraci.Add(item.Nadimak);
                }
                IspunjeniQuestiovi = new List<string>();
                foreach (var item in a.IspunjeniQuestiovi)
                {
                    IspunjeniQuestiovi.Add(item.Id.ToString());
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
