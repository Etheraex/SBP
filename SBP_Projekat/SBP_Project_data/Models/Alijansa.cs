﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_Project_data.Models
{
    public class Alijansa
    {
        public virtual int Id { get; set; }
        public virtual string Naziv { get; set; }
        public virtual int MinBrojIgraca { get; set; }
        public virtual int MaxBrojIgraca { get; set; }
        public virtual int XpBonus { get; set; }
        public virtual int HpBonus { get; set; }

        public virtual IList<Alijansa> Savezi { get; set; }
        public virtual IList<Igrac> Igraci { get; set; }
        public virtual IList<Quest> IspunjeniQuestiovi { get; set; }

        public Alijansa()
        {
            this.Savezi = new List<Alijansa>();
            this.Igraci = new List<Igrac>();
            this.IspunjeniQuestiovi = new List<Quest>();
        }

        public Alijansa(string n, int min, int max, int x, int h)
        {
            Naziv = n;
            MinBrojIgraca = min;
            MaxBrojIgraca = max;
            XpBonus = x;
            HpBonus = h;
            Savezi = new List<Alijansa>();
            Igraci = new List<Igrac>();
            this.IspunjeniQuestiovi = new List<Quest>();
        }
    }
}
