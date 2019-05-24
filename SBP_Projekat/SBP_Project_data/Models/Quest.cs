using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_Project_data.Models
{
    public class Quest
    {   
        public Quest()
        {
        }

        public virtual int Id { get; set; }
        public virtual int XpGain { get; set; }
        public virtual List<Predmet> Predmeti { get; set; }

        public Quest(int x)
        {
            XpGain = x;
            Predmeti = new List<Predmet>();
        }
    }
}
