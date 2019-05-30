using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBP_Data.DTOs
{
    public abstract class AbstractDTO
    {
        public Type EntityType { get; protected  set; }
        public abstract object ConvertToEntity();
        public int ID { get; set; }
        public abstract object Update(object x);
    }
}
