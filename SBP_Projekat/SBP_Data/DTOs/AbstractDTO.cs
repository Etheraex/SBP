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
        public abstract object CreateOrUpdate(object input = null);
        public int ID { get; set; }
    }
}
