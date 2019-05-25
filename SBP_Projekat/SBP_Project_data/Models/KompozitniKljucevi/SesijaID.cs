using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_Project_data.Models.KompozitniKljucevi
{
    public class SesijaID
    {
        public virtual Lik Lik { get; set; }
        public virtual Igrac Igrac { get; set; }


        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(SesijaID))
                return false;

            SesijaID recievedObject = (SesijaID)obj;

            if ((Lik.Id == recievedObject.Lik.Id) &&
                (Igrac.Id == recievedObject.Igrac.Id))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
