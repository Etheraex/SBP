﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBP_Data.Models;

namespace SBP_Data.DTOs
{
    public class IgracIspunjavaDTO : AbstractDTO
    {
        public int Vreme { get; set; }
        public Igrac Igrac { get; set; }
        public Quest Quest { get; set; }

        public IgracIspunjavaDTO()
        {

        }

        public override string ToString()
        {
            return EntityType.Name + Vreme;
        }

        public IgracIspunjavaDTO(IgracIspunjava i)
        {
            base.EntityType = typeof(IgracIspunjava);
            ID = i.Id;
            Vreme = i.Vreme;
            Igrac = i.Igrac;
            Quest = i.Quest;
        }

        public override object CreateOrUpdate(object input)
        {
            IgracIspunjava i = null;
            if (input != null)
                i = input as IgracIspunjava;
            else if (i == null || input == null)
                i = new IgracIspunjava();

            i.Vreme = Vreme;
            i.Igrac = Igrac;
            i.Quest = Quest;

            return i;
        }
    }
}