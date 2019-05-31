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

        public IList<Alijansa> Savezi { get; set; }
        public IList<Igrac> Igraci { get; set; }
        public IList<Quest> IspunjeniQuestiovi { get; set; }

        public AlijansaDTO()
        {
            base.EntityType = typeof(Alijansa);
        }

        public override string ToString()
        {
            return EntityType.Name + Naziv;
        }

        public AlijansaDTO(Alijansa a)
        {
            base.EntityType = typeof(Alijansa);
            ID = a.Id;
            Naziv = a.Naziv;
            MinBrojIgraca = a.MinBrojIgraca;
            MaxBrojIgraca = a.MaxBrojIgraca;
            XpBonus = a.XpBonus;
            HpBonus = a.HpBonus;
            Savezi = a.Savezi;
            Igraci = a.Igraci;
            IspunjeniQuestiovi = a.IspunjeniQuestiovi;
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
            a.Savezi = Savezi;
            a.Igraci = Igraci;
            a.IspunjeniQuestiovi = IspunjeniQuestiovi;

            return a;
        }
    }   
}
