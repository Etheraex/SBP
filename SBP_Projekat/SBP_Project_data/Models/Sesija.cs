﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBP_Project_data.Models.KompozitniKljucevi;

namespace SBP_Project_data.Models
{
    public class Sesija
    {
        public virtual SesijaID Id { get; set; }
        public virtual double Gold { get; set; }
        public virtual int ZaradjeniXP { get; set; }
        public virtual string VremePocetka { get; set; }
        public virtual string VremeKraja { get; set; }
    }
}