using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBP_Project_data.Models;

namespace SBP_Project_data.Models
{
    class AlijansaIspunjava
    {
        public virtual int Id { get; set; }
        public virtual int Vreme { get; set; }
        public virtual Alijansa Alijansa{ get; set; }
        public virtual Quest Quest{ get; set; }
    }
}
